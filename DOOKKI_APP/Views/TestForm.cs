using DOOKKI_APP.Helpers;
using DOOKKI_APP.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOOKKI_APP.Views
{
    public partial class TestForm : Form
    {
        DookkiContext _context;
        List<Admin> admins;
        public TestForm(DookkiContext context)
        {
            InitializeComponent();
            admins = new List<Admin>();
            _context = context;
            LoadCBEmployees();
            LoadCBRoles();
            LoadCBAccount();
            LoadCBRoles2();
        }
        private void LoadCBAccount()
        {
            admins = _context.Admins.ToList();
            foreach (Admin admin in admins)
            {
                cbAccount.Items.Add(admin.AdminUserName);
            }
            cbAccount.SelectedIndex = 0;
        }
        private void LoadCBRoles2()
        {
            string[] roles = { "admin", "cashier" };
            foreach (string role in roles)
            {
                cbRoles2.Items.Add(role);
            }
            cbRoles2.SelectedIndex = 0;
        }
        private void LoadCBEmployees()
        {
            List<Employee> employees = _context.Employees.ToList();

            List<string> employeeStrings = new List<string>();
            foreach (Employee employee in employees)
            {
                employeeStrings.Add(employee.EmployeeName + "(" + employee.Position + ")");
            }

            foreach (string employeeString in employeeStrings)
            {
                cbEmployee.Items.Add(employeeString);
            }
            cbEmployee.SelectedIndex = 0;
        }
        private void LoadCBRoles()
        {
            string[] roles = { "admin", "cashier" };
            foreach (string role in roles)
            {
                cbRole.Items.Add(role);
            }
            cbRole.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExportFile export = new ExportFile(_context);
                var newOrder = _context.Orders.ToList().ElementAt(2);
                if (newOrder != null)
                {
                    bool exported = export.ExportToPDF(newOrder);
                    if (exported)
                        MessageBox.Show("Xuat file thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Day ne: " + ex.Message);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string pass = txtPassword.Text;
                if (CheckAccountIsExist(userName))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại");
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Xác nhận cấp tài khoản", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Admin newadmin = new Admin();
                        var employee = (from em in _context.Employees
                                        where em.EmployeeId == cbEmployee.SelectedIndex + 1
                                        select em).Single();

                        newadmin.Roles = cbRole.SelectedItem.ToString();

                        newadmin.AdminUserName = userName;
                        newadmin.AdminPassword = pass;
                        newadmin.AdminPhone = employee.Phone;
                        newadmin.AdminName = employee.EmployeeName;
                        _context.Admins.Add(newadmin);
                        _context.SaveChanges();
                        MessageBox.Show("Cấp tài khoản thành công");
                        panel1.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAY : " + ex.Message);
            }
        }
        private bool CheckAccountIsExist(string userName)
        {
            var isExist = _context.Admins.Any(q => q.AdminUserName == userName);
            return isExist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string preRole = admins.ElementAt(cbAccount.SelectedIndex).Roles;
                string newRole = cbRoles2.SelectedItem.ToString();
                if (preRole != newRole)
                {
                    DialogResult dr = MessageBox.Show("Xác nhận đổi vai trò?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Admin admin = _context.Admins.First(q => q.AdminUserName == cbAccount.SelectedItem.ToString());
                        admin.Roles = newRole;
                        _context.Admins.Update(admin);
                        _context.SaveChanges();
                        MessageBox.Show("Đổi vai trò thành công.!");
                        panel2.Visible = false;
                    }
                }else
                {
                    MessageBox.Show("Không có gì thay đổi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(admins.ElementAt(cbAccount.SelectedIndex).Roles);
            if (admins.ElementAt(cbAccount.SelectedIndex).Roles == "admin")
            {
                cbRoles2.SelectedItem = "admin";
            }
            else if (admins.ElementAt(cbAccount.SelectedIndex).Roles == "cashier")
            {
                cbRoles2.SelectedItem = "cashier";

            }
        }

        private void btnExportSalary_Click(object sender, EventArgs e)
        {
            try
            {
                ExportFile export = new ExportFile(_context);
                export.ExportSalaryByMonthToExcel(DateTimePicker);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi loi le: ", ex.Message);
            }
            finally
            {
                MessageBox.Show("Xuat roi");
            }
        }

        private void btnRevenueByMonth_Click(object sender, EventArgs e)
        {
            try
            {
                ExportFile export = new ExportFile(_context);
                export.ExportRevenueByYearToDoc(DTPRevenue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi loi le: ", ex.Message);
            }
            finally
            {
                MessageBox.Show("Xuat roi");
            }
        }
    }
}
