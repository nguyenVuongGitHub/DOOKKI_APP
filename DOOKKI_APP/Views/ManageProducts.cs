﻿using DOOKKI_APP.Controllers;
using DOOKKI_APP.Helpers;
using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOOKKI_APP.Views
{
    public partial class ManageProducts : Form
    {
        private readonly ProductController _productController;
        private readonly CategoryController _categoryController;
        private readonly IServiceProvider _serviceProvider;
        private PageChanging<Product> _pageChanging;
        DookkiContext _context;
        public ManageProducts(DookkiContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _productController = new ProductController(context);
            _serviceProvider = serviceProvider;
            _pageChanging = new PageChanging<Product>(_productController.Products.ToList());
            _categoryController = new CategoryController(context);
        }
        // local method
        private int GetPageSize()
        {
            if (cbNumberOfPages.Items.Count < 0)
                return 10;

            return int.Parse(cbNumberOfPages.Text); // have no choice
        }
        private void LoadComboBox()
        {
            // load data from categoryName into combo box Category
            foreach (var item in _categoryController.GetModel())
            {
                cbCategory.Items.Add(item.Name);
            }
            string[] items = { "5", "10", "15", "20", "25", "30" };
            foreach (var item in items)
            {
                cbNumberOfPages.Items.Add(item);
            }
            cbNumberOfPages.SelectedIndex = 3;
        }
        private void LoadPageProduct()
        {
            _productController.DisplayToGirdView(dgvProducts, _pageChanging.CurrentPageIndex, GetPageSize());
            UpdateLableNumberPage();
        }
        private void UpdateLableNumberPage()
        {
            _pageChanging.UpdateTotalPages(GetPageSize());

            lbTotalPages.Text = $"Trang : {_pageChanging.CurrentPageIndex} / {_pageChanging.TotalPages}";
        }
        private void LoadDataGridView()
        {
            try
            {
                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.AllowUserToResizeColumns = false;
                dgvProducts.AllowUserToResizeRows = false;

                dgvProducts.Columns.Clear();
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "Name" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày sản xuất", DataPropertyName = "Mfg" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hạn sử dụng", DataPropertyName = "Exp" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng tồn kho", DataPropertyName = "UnitInStock" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại", DataPropertyName = "CategoryId" });

                LoadPageProduct();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at class ManageProduct(Form) function LoadDataGridView " + ex.Message);
            }
        }
        private void CustomFormatDateTimePicker(DateTimePicker dateTimePicker)
        {
            // custom format dd/MM/yyyy for dateTimePicker
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
        }
        private DateOnly GetDateFromTimePicker(DateTimePicker time)
        {
            // because time.Text is string => split by character '/'
            // => time.Text.Split('/') is a string array includes {day;month;year}
            int day = int.Parse(time.Text.Split('/')[0]);
            int month = int.Parse(time.Text.Split('/')[1]);
            int year = int.Parse(time.Text.Split('/')[2]);
            var date = new DateOnly(year, month, day);
            return date;
        }

        private bool CheckValidate()
        {
            errorProvider.Clear();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                isValid = false;
                errorProvider.SetError(txtName, "Tên không được để trống!!!");
            }
            if (string.IsNullOrWhiteSpace(txtUnitInStock.Text))
            {
                isValid = false;
                errorProvider.SetError(txtUnitInStock, "Số lượng không được để trống!!!");
            }
            else
            {
                if (!int.TryParse(txtUnitInStock.Text, out int value))
                {
                    isValid = false;
                    errorProvider.SetError(txtUnitInStock, "Không đúng định dạng");
                }
                else
                {
                    if (value <= 0)
                    {
                        isValid = false;
                        errorProvider.SetError(txtUnitInStock, "Số không được bé hơn 0");
                    }
                }
            }

            var mfg = GetDateFromTimePicker(dtpk_Mfg);

            var exp = GetDateFromTimePicker(dtpk_Exp);
            if (exp <= mfg)
            {
                isValid = false;
                errorProvider.SetError(dtpk_Mfg, "Ngày sản xuất phải lớn hơn hạn sử dụng");
                errorProvider.SetError(dtpk_Exp, "Ngày sản xuất phải lớn hơn hạn sử dụng");
            }
            if (cbCategory.SelectedIndex == -1)
            {
                isValid = false;
                errorProvider.SetError(cbCategory, "Chọn loại sản phẩm");
            }
            return isValid;
        }
        private void ClearInputFields()
        {
            txtName.Text = "";
            txtSearch.Text = "";
            txtUnitInStock.Text = "";
            btnUpdate.Enabled = false;
        }

        // view method
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBox();
            CustomFormatDateTimePicker(dtpk_Exp);
            CustomFormatDateTimePicker(dtpk_Mfg);
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            _pageChanging.PreviousPage();
            LoadPageProduct();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _pageChanging.NextPage();
            LoadPageProduct();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string search = txtSearch.Text.ToLower();

                _productController.Products = _productController.GetModel().Where(
                    p => p.Name.ToLower().Contains(search) ||
                        p.Category.Name.ToLower().Contains(search));

                _pageChanging.SetCurrentPage_1();
                _pageChanging.UpdateListOfModel(_productController.Products.ToList());
                LoadPageProduct();
            }
            else
            {
                _productController.Products = _productController.GetModel();
                _pageChanging.SetCurrentPage_1();
                _pageChanging.UpdateListOfModel(_productController.Products.ToList());
                LoadPageProduct();
            }
        }

        private void dgvProducts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvProducts.HitTest(e.X, e.Y);

                if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
                {
                    dgvProducts.ClearSelection();
                    dgvProducts.Rows[hit.RowIndex].Selected = true;

                    contextMenuStrip.Show(dgvProducts, e.Location);
                }
            }
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

                btnUpdate.Enabled = true;

                txtName.Text = selectedRow.Cells[1].Value?.ToString();
                dtpk_Mfg.Value = DateTime.ParseExact(selectedRow.Cells[2].Value?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dtpk_Exp.Value = DateTime.ParseExact(selectedRow.Cells[3].Value?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txtUnitInStock.Text = selectedRow.Cells[4].Value?.ToString();
                cbCategory.Text = selectedRow.Cells[5].Value?.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidate())
                {
                    Product newProduct = new Product();
                    newProduct.Name = txtName.Text;
                    newProduct.UnitInStock = int.Parse(txtUnitInStock.Text);

                    var mfg = GetDateFromTimePicker(dtpk_Mfg);

                    var exp = GetDateFromTimePicker(dtpk_Exp);

                    newProduct.CategoryId = cbCategory.SelectedIndex + 1;
                    newProduct.Exp = exp;
                    newProduct.Mfg = mfg;

                    _productController.Add(newProduct);
                    _productController.SaveChanges();

                    MessageBox.Show($"Thêm sản phẩm: \" {newProduct.Name} \" thành công");

                    LoadPageProduct();
                    ClearInputFields();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng số. Vui lòng kiểm tra lại các trường thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu thông tin: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int pageOffset = GetPageSize() * (_pageChanging.CurrentPageIndex - 1);

            try
            {
                int rowIndexOnPage = dgvProducts.SelectedRows[0].Index;
                int actualIndex = rowIndexOnPage + pageOffset;

                var products = _productController.GetModel().ToList();
                var product = (from p in _productController.GetModel()
                               where p.Id == products.ElementAt(actualIndex).Id
                               select p).SingleOrDefault();
                if (product != null)
                {
                    if (CheckValidate())
                    {

                        product.Name = txtName.Text;
                        product.UnitInStock = int.Parse(txtUnitInStock.Text);
                        product.Mfg = GetDateFromTimePicker(dtpk_Mfg);
                        product.Exp = GetDateFromTimePicker(dtpk_Exp);
                        product.CategoryId = cbCategory.SelectedIndex + 1;
                        btnUpdate.Enabled = false;
                        _productController.Update(product);
                        _productController.SaveChanges();
                        LoadPageProduct();
                        ClearInputFields();

                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    string name = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
                    string mfg = dgvProducts.SelectedRows[0].Cells[2].Value.ToString();
                    string exp = dgvProducts.SelectedRows[0].Cells[3].Value.ToString();

                    var product = _productController.GetModel().ToList()
                        .FirstOrDefault(p => p.Name == name && p.Mfg.ToString("dd/MM/yyyy") == mfg && p.Exp.ToString("dd/MM/yyyy") == exp); 
                    if (product != null)
                    {
                        DialogResult dr = MessageBox.Show($"Xác nhận xóa sản phẩm {product.Name}?", "Thông báo xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            //_productController.Remove(product);
                            product.IsActive = false;
                            _productController.Update(product);
                            _productController.SaveChanges();
                            LoadPageProduct();
                            MessageBox.Show("Xóa thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sp!");

                    }
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu thông tin: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNumberOfPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPageProduct();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                bool result = ImportFile.Instance.ImportFileProducts(_context, fileName);
                if (result)
                {
                    MessageBox.Show("Import thành công");
                    LoadPageProduct();
                }
                else
                {
                    MessageBox.Show("Import thất bại");
                }
            }
        }
    }
}
