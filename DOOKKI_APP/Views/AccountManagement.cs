using DOOKKI_APP.Controllers;
using DOOKKI_APP.Helpers;
using DOOKKI_APP.Models;
using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DOOKKI_APP.Views
{
    public partial class AccountManagement : Form
    {
        private readonly AdminController adminController;
        private readonly AccountController accountController;
        private readonly DookkiContext _context;
        bool isCurrentUser = false;
        string currentName = "", currentPhone = "";
        public AccountManagement(DookkiContext context)
        {
            InitializeComponent();
            _context = context;
            adminController = new AdminController(context);
            accountController = new AccountController(context);
            SetDataGridView();
            LoadGridView();
            LoadComboBox();
        }
        private void LoadGridView()
        {
            try
            {
                var adminList = adminController.GetModel().Where(a => a.IsActive == true)
                             .Join(accountController.GetModel().Where(a => a.IsActive == true),
                                 admin => admin.Idaccount,
                                 account => account.Id,
                                 (admin, account) => new { admin, account })
                             .ToList()
                             .Select((x, index) => new AdminAccountViewModel
                             {
                                 STT = index + 1, // Assuming you want 1-based indexing
                                 Name = x.admin.Name,
                                 Phone = x.admin.Phone,
                                 UserName = x.account.UserName,
                                 Password = x.account.Password,
                                 Role = x.account.Role
                             })
                             .ToList();


                dgvAdmin.DataSource = adminList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("load gird view: " + ex.Message);
            }


        }
        private bool IsValid(string currentName = "", string currentPhone = "")
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtUserName, "Tên đăng nhập không được để trống.");
            }
            else if (txtUserName.Text.Contains(' '))
            {
                isValid = false;
                errorProvider1.SetError(txtUserName, "Tên đăng nhập không được có khoảng trống.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtUserName.Text, "^[a-zA-Z0-9]+$"))
            {
                isValid = false;
                errorProvider1.SetError(txtUserName, "Tên đăng nhập chỉ được chứa các ký tự từ a-z và A-Z và số 0-9, không có dấu.");
            }
            else
            {
                // check duplicate username
                string userNameTest = "";

                userNameTest = txtUserName.Text;

                bool test = accountController.GetModel().Any(t => t.UserName == userNameTest && userNameTest != currentName);
                if (test)
                {
                    isValid = false;
                    errorProvider1.SetError(txtUserName, "Tên đăng nhập đã tồn tại.");
                }

            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtPassword, "Mật khẩu không được để trống.");
            }
            else if (txtPassword.Text.Contains(' '))
            {
                isValid = false;
                errorProvider1.SetError(txtPassword, "Mật khẩu không được có khoảng trống.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, "^[a-zA-Z0-9]+$"))
            {
                isValid = false;
                errorProvider1.SetError(txtPassword, "Mật khẩu chỉ được chứa các ký tự từ a-z và A-Z và số 0-9, không có dấu.");
            }


            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtName, "Tên không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Vui lòng nhập số điện thoại.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, @"^\d{10}$"))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại phải là 10 chữ số.");
                isValid = false;
            }
            else
            {

                string phoneTest = "";
                phoneTest = txtPhone.Text;
                bool test = adminController.GetModel().Any(t => t.Phone == phoneTest && t.Phone != currentPhone);
                if (test)
                {
                    isValid = false;
                    errorProvider1.SetError(txtPhone, "Số điện thoại đã tồn tại.");
                }


            }

            return isValid;
        }
        private void SetDataGridView()
        {
            try
            {
                dgvAdmin.AutoGenerateColumns = false;
                dgvAdmin.AllowUserToResizeColumns = false;
                dgvAdmin.AllowUserToResizeRows = false;
                dgvAdmin.ReadOnly = true;

                dgvAdmin.Columns.Clear();
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT", FillWeight = 25});
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "Name" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số điện thoại", DataPropertyName = "Phone" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tài khoản", DataPropertyName = "UserName" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mật khẩu", DataPropertyName = "Password" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quyền truy cập", DataPropertyName = "Role", FillWeight = 50});
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at class ADminManagement(Form) function SetDataGridView " + ex.Message);
            }
        }
        private void LoadComboBox()
        {
            string[] items = { "Vai trò", "admin", "employee" };
            foreach (var item in items)
            {
                cbRoles.Items.Add(item);
            }
            cbRoles.SelectedIndex = 0;
        }
        private void ClearInputFields()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            currentName = "";
            currentPhone = "";
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAdmin.SelectedRows[0];
                isCurrentUser = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnAddnew.Visible = false;
                groupBox2.Visible = true;
                btnUpdate.Enabled = true;
                cbRoles.Enabled = false;
                txtName.Text = selectedRow.Cells[1].Value?.ToString();
                txtPhone.Text = selectedRow.Cells[2].Value?.ToString();
                currentPhone = txtPhone.Text;
                txtUserName.Text = selectedRow.Cells[3].Value?.ToString();
                currentName = txtUserName.Text;
                txtPassword.Text = selectedRow.Cells[4].Value?.ToString();
                groupBox2.Text = selectedRow.Cells[5].Value?.ToString();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdmin.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvAdmin.SelectedRows[0];
                    int rowIndex = selectedRow.Index;

                    //var accounts = adminController.GetModel().ToList();
                    //var account = (from ac in adminController.GetModel()
                    //               where ac.Id == accounts.ElementAt(rowIndex).Id
                    //               select ac).SingleOrDefault();

                    var adminList = dgvAdmin.DataSource as List<AdminAccountViewModel>;
                    var selectedAdminFromView = adminList[rowIndex];
                    var admin = adminController.GetModel().FirstOrDefault(a => a.Name == selectedAdminFromView.Name && a.Phone == selectedAdminFromView.Phone);
                    var account = accountController.GetModel().FirstOrDefault(a => a.UserName == selectedAdminFromView.UserName);
                    if (admin != null && account != null)
                    {
                        DialogResult dr = MessageBox.Show($"Xác nhận xóa tài khoản {admin.Name}?", "Thông báo xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            admin.IsActive = false;
                            account.IsActive = false;

                            adminController.Update(admin);
                            adminController.SaveChanges();
                            accountController.Update(account);
                            accountController.SaveChanges();
                            LoadGridView();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // right click
            if (dgvAdmin.SelectedRows.Count > 0 && !isCurrentUser)
            {
                DataGridViewRow selectedRow = dgvAdmin.SelectedRows[0];
                int rowIndex = selectedRow.Index;
                var adminList = dgvAdmin.DataSource as List<AdminAccountViewModel>;
                var selectedAdminFromView = adminList[rowIndex];
                var admin = adminController.GetModel().FirstOrDefault(a => a.Name == selectedAdminFromView.Name && a.Phone == selectedAdminFromView.Phone);

                if (admin != null && IsValid(currentName, currentPhone))
                {
                    admin.Name = txtName.Text;

                    var account = (from acc in accountController.GetModel()
                                   where acc.Id == admin.Idaccount
                                   select acc).SingleOrDefault();
                    admin.Phone = txtPhone.Text;
                    if (account != null)
                    {
                        account.UserName = txtUserName.Text;
                        account.Password = txtPassword.Text;
                        accountController.Update(account);
                        accountController.SaveChanges();
                    }
                    adminController.Update(admin);
                    adminController.SaveChanges();

                    MessageBox.Show("Thành công");
                }
                else
                {
                    btnUpdate.Enabled = false;
                    MessageBox.Show("Thất bại");
                }
            }
            else if (isCurrentUser)
            {
                var account = (from acc in accountController.GetModel()
                               where acc.UserName == User.Username
                               select acc).Single();

                var admin = (from ad in adminController.GetModel()
                             where ad.Idaccount == account.Id
                             select ad).Single();
                if (IsValid(currentName, currentPhone))
                {
                    admin.Name = txtName.Text;
                    admin.Phone = txtPhone.Text;
                    account.UserName = txtUserName.Text;
                    account.Password = txtPassword.Text;
                    accountController.Update(account);
                    accountController.SaveChanges();
                    adminController.Update(admin);
                    adminController.SaveChanges();
                    MessageBox.Show("Thành công");
                }
                else
                {
                    btnUpdate.Enabled = false;
                    MessageBox.Show("Thất bại");
                }

            }
            LoadGridView();
            ClearInputFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            btnAddnew.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
            ClearInputFields();
            cbRoles.SelectedIndex = 0;
            cbRoles.Enabled = true;
        }

        private void dgvAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvAdmin.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
                {
                    dgvAdmin.ClearSelection();
                    dgvAdmin.Rows[hit.RowIndex].Selected = true;

                    contextMenuStrip1.Show(dgvAdmin, e.Location);
                }
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(currentName: "", currentPhone: ""))
                {
                    Admin ad = new Admin();
                    Account acc = new Account();

                    if (cbRoles.SelectedIndex == 1) // role admin
                    {
                        acc.Role = "admin";
                    }
                    else if (cbRoles.SelectedIndex == 2) // role employee
                    {
                        acc.Role = "employee";
                    }

                    acc.UserName = txtUserName.Text;
                    acc.Password = txtPassword.Text;

                    accountController.Add(acc);
                    accountController.SaveChanges();

                    ad.Name = txtName.Text;
                    ad.Phone = txtPhone.Text;
                    ad.Idaccount = acc.Id;
                    adminController.Add(ad);
                    adminController.SaveChanges();
                    MessageBox.Show("Thành công");
                    ClearInputFields();
                    LoadGridView();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // open panel infomation
        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            if (cbRoles.SelectedIndex == 0)
            {
                errorProvider1.SetError(cbRoles, "Chọn role");
                return;
            }
            cbRoles.Enabled = false;
            groupBox2.Visible = true;
            btnAddnew.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {

            try
            {
                groupBox2.Visible = true;
                btnAddnew.Visible = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnUpdate.Enabled = true;
                cbRoles.Enabled = false;
                groupBox2.Text = "Admin";
                var ad = (from admin in adminController.GetModel()
                          join account in accountController.GetModel()
                          on admin.Idaccount equals account.Id
                          where account.UserName == User.Username
                          select new
                          {
                              account.UserName,
                              account.Password,
                              admin.Name,
                              admin.Phone
                          }).SingleOrDefault();

                if (ad != null)
                {
                    txtUserName.Text = ad.UserName;
                    txtPassword.Text = ad.Password;
                    txtName.Text = ad.Name;
                    txtPhone.Text = ad.Phone;
                    currentName = txtUserName.Text;
                    currentPhone = txtPhone.Text;
                }
                isCurrentUser = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("edit: " + ex.Message);
            }
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoles.SelectedIndex != 0)
            {
                errorProvider1.Clear();
                groupBox2.Text = cbRoles.Text;
            }
        }
    }
}
