using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOKKI_APP.Models.Entities;
using Spire.Doc;
using System.IO;
using System.Diagnostics;
using Spire.Xls;
using Guna.UI2.WinForms;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Collections;
using static DOOKKI_APP.Helpers.DashboardHelper;


namespace DOOKKI_APP.Helpers
{
    internal class ExportFile
    {
        private string solutionDirectory;
        private string assetsDirectory;
        private string OutputFileDirectory;
        private string fileTemplateBill;
        private string fileTemplateRevenue;
        private DookkiContext _context;
        public ExportFile(DookkiContext context)
        {
            // get direction of solution
            solutionDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            assetsDirectory = Path.Combine(solutionDirectory, "Assets");
            OutputFileDirectory = Path.Combine(solutionDirectory, "OutputFile");
            fileTemplateBill = Path.Combine(assetsDirectory, "Template", "Bill.docx");
            fileTemplateRevenue = Path.Combine(assetsDirectory, "Template", "RevenueTemplate.docx");
            _context = context;
        }
        /// <summary>
        /// Export file PDF with the order
        /// </summary>
        /// <param name="order"></param>
        /// <returns> true if successful</returns>
        public bool ExportToPDF(Order order)
        {
            try
            {

                Document document = new Document();
                document.LoadFromFile(fileTemplateBill);


                var query = (from od in _context.OrderDetails
                             join o in _context.Orders on od.OrderId equals o.Id
                             join t in _context.Tickets on od.TicketId equals t.Id
                             join p in _context.Payments on od.PaymentId equals p.Id
                             join pm in _context.PaymentMethods on p.PaymentMethodId equals pm.Id
                             where o.Id == order.Id
                             select new
                             {
                                 Ticket = t,
                                 Payment = p,
                                 PaymentMethod = pm,
                                 OrderDetail = od,
                             }).ToList();


                var firstOrder = query.FirstOrDefault();
                if (firstOrder == null) return false;



                document.Replace("{EmployeeName}", User.Name, false, true);
                document.Replace("{Date}", query.ElementAt(0).Payment.Day.ToString(), false, true);
                document.Replace("{CustomerName}", order?.Customer?.Name ?? string.Empty, false, true);
                document.Replace("{PaymentMethod}", query.ElementAt(0).PaymentMethod.Name, false, true);

                // Calculate total bill
                decimal totalBill = query.Sum(item => item.Ticket.Price * item.OrderDetail.Quantily);


                TextSelection selection = document.FindString("{OrderDetails}", true, true);
                TextRange range = selection.GetAsOneRange();
                Section section = range.OwnerParagraph.OwnerTextBody.Owner as Section;
                int index = section.Body.ChildObjects.IndexOf(range.OwnerParagraph);

                // Create a table
                Spire.Doc.Table tableOrderDetails = section.AddTable(true);
                tableOrderDetails.ResetCells(query.Count + 1, 3); // Set number of rows and columns
                tableOrderDetails.TableFormat.HorizontalAlignment = RowAlignment.Center;
                foreach (TableRow row in tableOrderDetails.Rows)
                {
                    row.Cells[0].Width = 400;
                    row.Cells[1].Width = 100;
                    row.Cells[2].Width = 200;
                }

                // format here
                Paragraph headerPara0 = tableOrderDetails.Rows[0].Cells[0].AddParagraph();
                TextRange header1Text = headerPara0.AppendText("Tên");
                header1Text.CharacterFormat.FontName = "Times New Roman";
                header1Text.CharacterFormat.FontSize = 14;
                header1Text.CharacterFormat.Bold = true;
                headerPara0.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                tableOrderDetails.Rows[0].Cells[0].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Middle;
                tableOrderDetails.Rows[0].Cells[0].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                tableOrderDetails.Rows[0].Cells[0].CellFormat.Borders.Color = Color.Gray;

                Paragraph headerPara1 = tableOrderDetails.Rows[0].Cells[1].AddParagraph();
                TextRange header2Text = headerPara1.AppendText("Số lượng");
                header2Text.CharacterFormat.FontName = "Times New Roman";
                header2Text.CharacterFormat.FontSize = 14;
                header2Text.CharacterFormat.Bold = true;
                headerPara1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                tableOrderDetails.Rows[0].Cells[1].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Middle;
                tableOrderDetails.Rows[0].Cells[1].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                tableOrderDetails.Rows[0].Cells[1].CellFormat.Borders.Color = Color.Gray;

                Paragraph headerPara2 = tableOrderDetails.Rows[0].Cells[2].AddParagraph();
                TextRange header3Text = headerPara2.AppendText("Đơn giá");
                header3Text.CharacterFormat.FontName = "Times New Roman";
                header3Text.CharacterFormat.FontSize = 14;
                header3Text.CharacterFormat.Bold = true;

                headerPara2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                tableOrderDetails.Rows[0].Cells[2].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Middle;
                tableOrderDetails.Rows[0].Cells[2].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                tableOrderDetails.Rows[0].Cells[2].CellFormat.Borders.Color = Color.Gray;

                // Insert data into the table with a tab character at the beginning of each cell
                int rowTable = 1;
                Paragraph para;
                foreach (var item in query)
                {
                    string ticketName = item.Ticket.Name;
                    string quantity = item.OrderDetail.Quantily.ToString();
                    string price = item.Ticket.Price.ToString("#,##0 VND");

                    // Tính tổng
                    totalBill += item.Ticket.Price * item.OrderDetail.Quantily;

                    // ticket name
                    para = tableOrderDetails.Rows[rowTable].Cells[0].AddParagraph();
                    TextRange ticketNameText = para.AppendText(ticketName);
                    ticketNameText.CharacterFormat.FontName = "Times New Roman";
                    ticketNameText.CharacterFormat.FontSize = 13;
                    para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                    tableOrderDetails.Rows[rowTable].Cells[0].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.DashSmallGap;
                    tableOrderDetails.Rows[rowTable].Cells[0].CellFormat.Borders.Color = Color.Gray;

                    // quantity
                    para = tableOrderDetails.Rows[rowTable].Cells[1].AddParagraph();
                    TextRange quantityText = para.AppendText(quantity);
                    quantityText.CharacterFormat.FontName = "Times New Roman";
                    quantityText.CharacterFormat.FontSize = 13;
                    para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                    tableOrderDetails.Rows[rowTable].Cells[1].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.DashSmallGap;
                    tableOrderDetails.Rows[rowTable].Cells[1].CellFormat.Borders.Color = Color.Gray;

                    // price
                    para = tableOrderDetails.Rows[rowTable].Cells[2].AddParagraph();
                    TextRange priceText = para.AppendText(price);
                    priceText.CharacterFormat.FontName = "Times New Roman";
                    priceText.CharacterFormat.FontSize = 13;
                    para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                    tableOrderDetails.Rows[rowTable].Cells[2].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.DashSmallGap;
                    tableOrderDetails.Rows[rowTable].Cells[2].CellFormat.Borders.Color = Color.Gray;

                    rowTable++;
                }




                // Remove the placeholder paragraph
                section.Body.ChildObjects.Remove(range.OwnerParagraph);

                // Insert the table at the placeholder's position
                section.Body.ChildObjects.Insert(index, tableOrderDetails);


                // Tính toán phần trăm giảm giá dựa trên giá trị của Discount
                decimal discountRate = order?.Discount switch
                {
                    1 => 0.05m,
                    2 => 0.20m,
                    3 => 0.25m,
                    4 => 0.30m,
                    5 => 0.40m,
                    _  => 0m
                };
                // Tính toán FinalCost sau khi áp dụng giảm giá
                decimal finalCost = totalBill * (1 - discountRate);
                decimal change = query.ElementAt(0).Payment.Amount - finalCost;


                TextSelection selection2 = document.FindString("{Information}", true, true);
                TextRange range2 = selection2.GetAsOneRange();
                Section section2 = range2.OwnerParagraph.OwnerTextBody.Owner as Section;
                int index2 = section.Body.ChildObjects.IndexOf(range2.OwnerParagraph);

                // Create a table
                Spire.Doc.Table Information = section.AddTable(true);
                Information.ResetCells(5, 2); // Set number of rows and columns
                Information.TableFormat.HorizontalAlignment = RowAlignment.Center;

                // Insert data into the table with a tab character at the beginning of each cell

                para = Information.Rows[0].Cells[0].AddParagraph();
                TextRange totalBillText = para.AppendText("Thành tiền");
                totalBillText.CharacterFormat.FontName = "Times New Roman";
                totalBillText.CharacterFormat.FontSize = 14;
                totalBillText.CharacterFormat.Bold = true;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                Information.Rows[0].Cells[0].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[0].Cells[0].CellFormat.Borders.Color = Color.White;


                para = Information.Rows[0].Cells[1].AddParagraph();
                TextRange totalBillText2 = para.AppendText(totalBill.ToString("#,##0 VND"));
                totalBillText2.CharacterFormat.FontName = "Times New Roman";
                totalBillText2.CharacterFormat.FontSize = 14;
                totalBillText2.CharacterFormat.Bold = true;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                Information.Rows[0].Cells[1].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[0].Cells[1].CellFormat.Borders.Color = Color.White;


                para = Information.Rows[1].Cells[0].AddParagraph();
                TextRange discountText = para.AppendText("Khuyến mại");
                discountText.CharacterFormat.FontName = "Times New Roman";
                discountText.CharacterFormat.FontSize = 13;
                discountText.CharacterFormat.Italic = true;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                Information.Rows[1].Cells[0].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[1].Cells[0].CellFormat.Borders.Color = Color.White;


                para = Information.Rows[1].Cells[1].AddParagraph();
                TextRange discountText2 = para.AppendText((discountRate * 100).ToString() + " %");
                discountText2.CharacterFormat.FontName = "Times New Roman";
                discountText2.CharacterFormat.FontSize = 13;
                discountText2.CharacterFormat.Italic = true;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                Information.Rows[1].Cells[1].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[1].Cells[1].CellFormat.Borders.Color = Color.White;

                para = Information.Rows[2].Cells[0].AddParagraph();
                TextRange finalCostText = para.AppendText("Tổng thanh toán");
                finalCostText.CharacterFormat.FontName = "Times New Roman";
                finalCostText.CharacterFormat.FontSize = 14;
                finalCostText.CharacterFormat.Bold = true;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                Information.Rows[2].Cells[0].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[2].Cells[0].CellFormat.Borders.Color = Color.White;

                para = Information.Rows[2].Cells[1].AddParagraph();
                TextRange finalCostText2 = para.AppendText(finalCost.ToString("#,##0 VND"));
                finalCostText2.CharacterFormat.FontName = "Times New Roman";
                finalCostText2.CharacterFormat.FontSize = 14;
                finalCostText2.CharacterFormat.Bold = true;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                Information.Rows[2].Cells[1].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[2].Cells[1].CellFormat.Borders.Color = Color.White;


                para = Information.Rows[3].Cells[0].AddParagraph();
                TextRange amountText = para.AppendText("Tiền nhận");
                amountText.CharacterFormat.FontName = "Times New Roman";
                amountText.CharacterFormat.FontSize = 13;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                Information.Rows[3].Cells[0].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[3].Cells[0].CellFormat.Borders.Color = Color.White;

                para = Information.Rows[3].Cells[1].AddParagraph();
                TextRange amountText2 = para.AppendText((query.ElementAt(0).Payment.Amount).ToString("#,##0 VND"));
                amountText2.CharacterFormat.FontName = "Times New Roman";
                amountText2.CharacterFormat.FontSize = 13;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                Information.Rows[3].Cells[1].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[3].Cells[1].CellFormat.Borders.Color = Color.White;

                para = Information.Rows[4].Cells[0].AddParagraph();
                TextRange changeText = para.AppendText("Trả lại khách");
                changeText.CharacterFormat.FontName = "Times New Roman";
                changeText.CharacterFormat.FontSize = 14;
                changeText.CharacterFormat.Bold = true;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                Information.Rows[4].Cells[0].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[4].Cells[0].CellFormat.Borders.Color = Color.White;

                para = Information.Rows[4].Cells[1].AddParagraph();
                TextRange changeText2 = para.AppendText(change.ToString("#,##0 VND"));
                changeText2.CharacterFormat.FontName = "Times New Roman";
                changeText2.CharacterFormat.FontSize = 14;
                changeText2.CharacterFormat.Bold = true;
                para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                Information.Rows[4].Cells[1].CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single;
                Information.Rows[4].Cells[1].CellFormat.Borders.Color = Color.White;

                // Remove the placeholder paragraph
                section2.Body.ChildObjects.Remove(range2.OwnerParagraph);

                // Insert the table at the placeholder's position
                section2.Body.ChildObjects.Insert(index2, Information);

                string outputFilePath = Path.Combine(OutputFileDirectory, "Bill_" + order?.Id + ".pdf");
                document.SaveToFile(outputFilePath, Spire.Doc.FileFormat.PDF);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        /// <summary>
        /// export employee salary
        /// </summary>
        public void ExportSalaryByMonthToExcel(Guna2DateTimePicker dateTimePickerFilter)
        {
            try
            {
                int selectedMonth = dateTimePickerFilter.Value.Month;
                int selectedYear = dateTimePickerFilter.Value.Year;

                // LINQ query salary of employee by choosed month
                var query = from e in _context.Employees
                            join w in _context.DayWorks on e.Id equals w.EmployeeId
                            where w.Day.Value.Month == selectedMonth &&
                                  w.Day.Value.Year == selectedYear
                            group w by new { e.Id, e.Name, e.AmountWage } into g
                            select new
                            {
                                EmployeeID = g.Key.Id,
                                Name = g.Key.Name,
                                TotalSalary = g.Sum(w => w.TimeWork * g.Key.AmountWage)
                            };
                Workbook workbook = new Workbook();
                Worksheet sheet = workbook.Worksheets[0];

                // Init Headder
                sheet.Range["A1"].Text = "Employee ID";
                sheet.Range["B1"].Text = "Name";
                sheet.Range["C1"].Text = "Total Salary";

                // Export data
                int row = 2;
                foreach (var item in query)
                {
                    sheet.Range["A" + row].NumberValue = item.EmployeeID;
                    sheet.Range["B" + row].Text = item.Name;
                    sheet.Range["C" + row].NumberValue = (double)item.TotalSalary;
                    row++;
                }

                // Format salary column
                sheet.Range["C2:C" + (row - 1)].NumberFormat = "#,###";

                // Save file
                string filePath = Path.Combine(OutputFileDirectory, "Salary_" + dateTimePickerFilter?.Value.Month + ".Xlsm");
                workbook.SaveToFile(filePath, Spire.Xls.FileFormat.Xlsm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// export company's income 
        /// </summary>
        public void ExportRevenueByYearToDoc(Guna2DateTimePicker dateTimePickerFilterRevenue)
        {
            try
            {
                int selectedYear = dateTimePickerFilterRevenue.Value.Year;
                Document doc = new Document();
                doc.LoadFromFile(fileTemplateRevenue);
                var query = _context.Payments
                    .Where(p => p.Day.Year == selectedYear)
                    .Sum(p => p.Amount);
                doc.Replace("{YearBegin}", (selectedYear - 1).ToString(), false, true);
                doc.Replace("{YearEnd}", selectedYear.ToString(), false, true);
                doc.Replace("{TotalPayment}", $"{query:F2}", false, true);
                doc.Replace("{Total}", $"{query:F2}", false, true);

                string outputFilePath = Path.Combine(OutputFileDirectory, "Revenue_" + selectedYear + ".docx");
                doc.SaveToFile(outputFilePath, Spire.Doc.FileFormat.Docx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ExportDashboard(DashboardController dashboard, DateTime date)
        {
            try
            {
                Workbook workbook = new Workbook();
                Worksheet sheet = workbook.Worksheets[0];

                // Init Headder
                sheet.Range["A1"].Text = "Date";
                sheet.Range["B1"].Text = "Revenue";

                // Export data
                int row = 2;
                foreach (var item in dashboard.GrossRevenueList)
                {
                    sheet.Range["A" + row].Text = item.Date.ToString();
                    sheet.Range["B" + row].Text = item.TotalAmount.ToString();
                    row++;
                }


                // Save file
                string filePath = Path.Combine(OutputFileDirectory, "Dashboard_" + date.Month + ".Xlsm");
                workbook.SaveToFile(filePath, Spire.Xls.FileFormat.Xlsm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
