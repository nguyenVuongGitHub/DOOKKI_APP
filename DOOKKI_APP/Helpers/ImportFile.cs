using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Helpers
{
    public class ImportFile
    {
        private static readonly Lazy<ImportFile> _instance = new Lazy<ImportFile>(() => new ImportFile());
        public static ImportFile Instance => _instance.Value;

        public ImportFile()
        {

        }
        private bool CheckValidDateProduct(string name, string unit, string mfg, string exp, string catName)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(catName))
            {
                return false;
            }

            if (!int.TryParse(unit, out int re))
            {
                return false;
            }

            if (!DateOnly.TryParseExact(mfg,"dd/MM/yyyy",out DateOnly mfgOut) && !DateOnly.TryParseExact(exp, "dd/MM/yyyy", out DateOnly expOut))
            {
                if(mfgOut > expOut)
                {
                    return false;
                }
            }
            return true;
        }
        public bool ImportFileProducts(DookkiContext context, string filePath)
        {
            bool result = true;
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (file == null)
                    return false;
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // First worksheet
                    int rows = worksheet.Dimension.Rows;
                    int columns = worksheet.Dimension.Columns;

                    // row start = 2 because row 1 is header
                    for (int row = 2; row <= rows; row++)
                    {
                        var name = worksheet.Cells[row, 2].Text;
                        var mfg = worksheet.Cells[row, 4].Text;
                        var exp = worksheet.Cells[row, 5].Text;
                        var categoryName = worksheet.Cells[row, 6].Text;
                        var unit = int.Parse(worksheet.Cells[row, 3].Text);
                        if (!CheckValidDateProduct(name, worksheet.Cells[row, 3].Text, mfg, exp, categoryName))
                        {
                            MessageBox.Show("Lỗi tại hàng " + row);
                            return false;
                        }

                        var product = context.Products.
                                    Include(p => p.Category)
                                    .Where((p => p.Name == name
                                        && p.Exp == DateOnly.ParseExact(exp,"dd/MM/yyyy")
                                        && p.Mfg == DateOnly.ParseExact(mfg, "dd/MM/yyyy")
                                        && p.Category.Name.Equals(categoryName)
                                        && p.IsActive == true)
                                    )
                                    .FirstOrDefault();

                        if (product != null)
                        {
                            product.UnitInStock += unit;
                            context.Products.Update(product);
                        }
                        else
                        {
                            Product newP = new Product
                            {
                                Name = name,
                                Mfg = DateOnly.ParseExact(mfg, "dd/MM/yyyy"),
                                Exp = DateOnly.ParseExact(exp, "dd/MM/yyyy"),
                                CategoryId = context.Categories.FirstOrDefault(c => c.Name.Equals(categoryName))?.Id,
                                UnitInStock = unit,
                                IsActive = true
                            };
                            context.Products.Add(newP);
                        }
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
