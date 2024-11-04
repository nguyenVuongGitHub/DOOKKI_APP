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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DOOKKI_APP.Views
{
    public partial class ManageEployee : Form
    {
        private readonly DookkiContext _context;
        public ManageEployee(DookkiContext context)
        {
            InitializeComponent();
            _context = context;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                var employees = _context.Employees
                                        .Select(e => new
                                        {
                                            e.EmployeeId,
                                            e.EmployeeName,
                                            e.Phone,
                                            e.Email,
                                            e.AmountWage,
                                            e.Position
                                        })
                                        .ToList();

                dgvEmployee.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployee(string employeeName, string phone, string email, decimal amountWage, string position)
        {
            try
            {
                using (var context = new DookkiContext())
                {
                    var employee = new Employee
                    {
                        EmployeeName = employeeName,
                        Phone = phone,
                        Email = email,
                        AmountWage = amountWage,
                        Position = position
                    };

                    // Thêm nhân viên vào database và lưu thay đổi
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên: " + ex.InnerException?.Message ?? ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveEmployee()
        {
            try
            {
                if (dgvEmployee.SelectedRows.Count > 0)
                {
                    int employeeId = (int)dgvEmployee.SelectedRows[0].Cells["EmployeeId"].Value;

                    using (var context = new DookkiContext())
                    {
                        var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);

                        if (employee != null)
                        {
                            context.Employees.Remove(employee);
                            context.SaveChanges();
                            MessageBox.Show("Xóa nhân viên thành công!");
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("Nhân viên không tồn tại!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }



        private void EditEmployee(int employeeID, string employeeName, string phone, string email, decimal amountWage, string position)
        {
            try
            {
                using (var context = new DookkiContext())
                {
                    var employee = context.Employees.Find(employeeID);
                    if (employee != null)
                    {
                        employee.EmployeeName = employeeName;
                        employee.Phone = phone;
                        employee.Email = email;
                        employee.AmountWage = amountWage;
                        employee.Position = position;

                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ManageEployee_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            btnUpdate.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string employeeName = txtName.Text;
            string phone = txtPhoneNum.Text;
            string email = txtEmail.Text;
            decimal amountWage = decimal.Parse(txtWage.Text);
            string position = cmbPosition.Text;

            // Kiểm tra và chuyển đổi dữ liệu mức lương
            if (!decimal.TryParse(txtWage.Text, out amountWage))
            {
                MessageBox.Show("Vui lòng nhập mức lương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm AddEmployee để thêm nhân viên mới vào cơ sở dữ liệu
            AddEmployee(employeeName, phone, email, amountWage, position);
            Clear_Texbox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveEmployee();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                int employeeID = (int)row.Cells["EmployeeID"].Value;
                string employeeName = row.Cells["EmployeeName"].Value.ToString();
                string phone = row.Cells["Phone"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                decimal amountWage = (decimal)row.Cells["AmountWage"].Value;
                string position = row.Cells["Position"].Value.ToString();

                txtID.Text = employeeID.ToString();
                txtName.Text = employeeName;
                txtPhoneNum.Text = phone;
                txtEmail.Text = email;
                txtWage.Text = amountWage.ToString();
                cmbPosition.Text = position;

                txtName.Enabled = true;
                txtPhoneNum.Enabled = true;
                txtEmail.Enabled = true;
                txtWage.Enabled = true;
                cmbPosition.Enabled = true;

                btnUpdate.Visible = true;
                btnEdit.Visible = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int employeeID = int.Parse(txtID.Text);
            string employeeName = txtName.Text;
            string phone = txtPhoneNum.Text;
            string email = txtEmail.Text;
            decimal amountWage = decimal.Parse(txtWage.Text);
            string position = cmbPosition.Text;

            // Gọi hàm EditEmployee để cập nhật vào database
            EditEmployee(employeeID, employeeName, phone, email, amountWage, position);
            btnEdit.Visible = true;
            btnUpdate.Visible = false;
            Clear_Texbox();
        }

        private void Clear_Texbox()
        {
            // Xóa hoặc đặt lại các ô nhập liệu
            txtID.Clear();
            txtName.Clear();
            txtPhoneNum.Clear();
            txtEmail.Clear();
            txtWage.Clear();
            cmbPosition.SelectedIndex = -1;

            // Đặt lại trạng thái nút: Hiển thị nút Edit, ẩn nút Update
            btnEdit.Visible = true;
            btnUpdate.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear_Texbox();
        }
    }
}
