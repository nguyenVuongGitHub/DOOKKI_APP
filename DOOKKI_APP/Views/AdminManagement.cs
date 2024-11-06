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
    public partial class AdminManagement : Form
    {
        private readonly AdminController adminController;
        private readonly DookkiContext _context;
        bool isCurrentUser = false;
        public AdminManagement(DookkiContext context)
        {
            InitializeComponent();
            _context = context;
            adminController = new AdminController(_context);
            SetDataGridView();
            LoadGridView();
            LoadComboBox();
        }
        private void LoadGridView()
        {
            try
            {
                dgvAdmin.DataSource = adminController.Query.ToList().Select(
                    (x,index) => new AdminInfo
                {
                    STT = index + 1,
                    Name = x.AdminName,
                    Phone = x.AdminPhone,
                    UserName = x.AdminUserName,
                    Password = x.AdminPassword,
                    Role = x.Roles
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "Name" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số điện thoại", DataPropertyName = "Phone" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tài khoản", DataPropertyName = "UserName" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mật khẩu", DataPropertyName = "Password" });
                dgvAdmin.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quyền truy cập", DataPropertyName = "Role" });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at class ADminManagement(Form) function SetDataGridView " + ex.Message);
            }
        }
        private void LoadComboBox()
        {
            string[] items = { "", "Admin", "Cashier" };
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
                pnAddNewAccount.Visible = true;
                txtName.Text = selectedRow.Cells[1].Value?.ToString();
                txtPhone.Text = selectedRow.Cells[2].Value?.ToString();
                txtUserName.Text = selectedRow.Cells[3].Value?.ToString();
                txtPassword.Text = selectedRow.Cells[4].Value?.ToString();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdmin.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvAdmin.SelectedRows[0];
                    int index = int.Parse(selectedRow.Cells[0].Value?.ToString());
                    var accounts = adminController.GetModel().ToList();

                    var account = (from ac in adminController.GetModel()
                                   where ac.AdminId == accounts.ElementAt(index).AdminId
                                   select ac).SingleOrDefault();

                    if (account != null)
                    {
                        DialogResult dr = MessageBox.Show($"Xác nhận xóa tài khoản {account.AdminName}?", "Thông báo xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            adminController.Remove(account);
                            adminController.SaveChanges();
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
                int index = int.Parse(selectedRow.Cells[0].Value?.ToString());
                var accounts = adminController.GetModel().ToList();

                var account = (from ac in adminController.GetModel()
                               where ac.AdminId == accounts.ElementAt(index).AdminId
                               select ac).SingleOrDefault(); 

                if (account != null)
                {
                    account.AdminName = txtName.Text;
                    account.AdminUserName = txtUserName.Text;
                    account.AdminPassword = txtPassword.Text;
                    account.AdminPhone = txtPhone.Text;
                    adminController.Update(account);
                    adminController.SaveChanges();
                    MessageBox.Show("Thành công");
                }else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else if (isCurrentUser)
            {
                var ad = (from a in _context.Admins where a.AdminUserName == User.Username select a).Single();
                ad.AdminPhone = txtPhone.Text;
                ad.AdminUserName = txtUserName.Text;
                ad.AdminPassword = txtPassword.Text;
                ad.AdminName = txtName.Text;
                adminController.Update(ad);
                adminController.SaveChanges();
                MessageBox.Show("Thành công");
            }
            LoadGridView();
            ClearInputFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnAddNewAccount.Visible = false;
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
                Admin ad = new Admin();
                ad.AdminName = txtName.Text;
                ad.AdminUserName = txtUserName.Text;
                ad.AdminPassword = txtPassword.Text;
                ad.AdminPhone = txtPhone.Text;
                if (cbRoles.Text == "Admin")
                {
                    ad.Roles = "admin";
                }
                else if (cbRoles.Text == "Cashier")
                {
                    ad.Roles = "cashier";
                }
                adminController.Add(ad);
                adminController.SaveChanges();
                MessageBox.Show("Thành công");
                ClearInputFields();
                LoadGridView();
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
            pnAddNewAccount.Visible = true;
            btnAddnew.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            pnAddNewAccount.Visible = true;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
            var ad = (from a in _context.Admins where a.AdminUserName == User.Username select a).Single();
            if (ad != null)
            {
                txtUserName.Text = ad.AdminUserName;
                txtPassword.Text = ad.AdminPassword;
                txtName.Text = ad.AdminName;
                txtPhone.Text = ad.AdminPhone;
            }
            isCurrentUser = true;
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoles.SelectedIndex != 0)
            {
                errorProvider1.Clear();
            }
        }
    }
}
