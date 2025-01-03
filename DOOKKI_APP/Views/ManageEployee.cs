using DOOKKI_APP.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DOOKKI_APP.Views
{
    public partial class ManageEployee : Form
    {
        private readonly DookkiContext _context;
        string currentPhone = "";
        public ManageEployee(DookkiContext context)
        {
            InitializeComponent();
            _context = context;

            LoadGridView();
            //dgvEmployee.CellClick += dgvEmployee_CellClick;

        }
        void LoadGridView()
        {
            try
            {
                dgvEmployee.AutoGenerateColumns = false;
                dgvEmployee.AllowUserToResizeColumns = false;
                dgvEmployee.AllowUserToResizeRows = false;

                dgvEmployee.Columns.Clear();
                dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT", FillWeight = 25 });
                dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "Name" });
                dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số điện thoại", DataPropertyName = "Phone" });
                dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
                dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lương", DataPropertyName = "AmountWage", FillWeight = 50 });
                dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vị trí", DataPropertyName = "Position", FillWeight = 50 });

                LoadEmployees();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at class ManageProduct(Form) function LoadDataGridView " + ex.Message);
            }
        }
        private void LoadEmployees()
        {
            try
            {
                dgvEmployee.DataSource = null;
                var employees = _context.Employees.ToList()
                                        .Where(e => e.IsActive == true)
                                        .Select((e, index) => new
                                        {
                                            STT = index + 1,
                                            Name = e.Name,
                                            Phone = e.Phone,
                                            Email = e.Email,
                                            AmountWage = e.AmountWage,
                                            Position = e.Position
                                        })
                                        .ToList();

                dgvEmployee.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInput(string currentPhone = "")
        {
            bool isValid = true;

            // Xóa các lỗi cũ
            errorProvider.Clear();

            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Vui lòng nhập tên nhân viên.");
                isValid = false;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtPhoneNum.Text))
            {
                errorProvider.SetError(txtPhoneNum, "Vui lòng nhập số điện thoại.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNum.Text, @"^\d{10}$"))
            {
                errorProvider.SetError(txtPhoneNum, "Số điện thoại phải là 10 chữ số.");
                isValid = false;
            }
            else
            {
                // check trung so dien thoai

                string phoneTest = txtPhoneNum.Text;

                bool isExist = _context.Employees.Any(e => e.Phone == phoneTest && e.Phone != currentPhone);
                if (isExist)
                {
                    errorProvider.SetError(txtPhoneNum, "Số điện thoại đã tồn tại.");
                    isValid = false;
                }

            }

            // Kiểm tra email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Vui lòng nhập email.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(txtEmail, "Email không hợp lệ. Vui lòng nhập đúng định dạng.");
                isValid = false;
            }

            // Kiểm tra mức lương
            if (string.IsNullOrWhiteSpace(txtWage.Text))
            {
                errorProvider.SetError(txtWage, "Vui lòng nhập mức lương.");
                isValid = false;
            }
            else if (!decimal.TryParse(txtWage.Text, out decimal wage) || wage <= 0)
            {
                errorProvider.SetError(txtWage, "Mức lương phải là một số dương.");
                isValid = false;
            }

            // Kiểm tra vị trí
            if (string.IsNullOrWhiteSpace(cmbPosition.Text))
            {
                errorProvider.SetError(cmbPosition, "Vui lòng chọn vị trí.");
                isValid = false;
            }

            return isValid;
        }



        private void AddEmployee(string employeeName, string phone, string email, decimal amountWage, string position)
        {
            try
            {

                var employee = new Employee
                {
                    Name = employeeName,
                    Phone = phone,
                    Email = email,
                    AmountWage = amountWage,
                    Position = position
                };

                // Thêm nhân viên vào database và lưu thay đổi
                _context.Employees.Add(employee);
                _context.SaveChanges();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên: " + ex.InnerException?.Message ?? ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveEmployee(string phone)
        {
            try
            {
                if (dgvEmployee.SelectedRows.Count > 0)
                {
                    // Sửa tên cột từ "EmployeeId" thành "Id"
                    //int employeeId = (int)dgvEmployee.SelectedRows[0].Cells["Id"].Value;
                    var employee = _context.Employees.FirstOrDefault(e => e.Phone == phone);

                    if (employee != null)
                    {
                        //context.Employees.Remove(employee);
                        employee.IsActive = false;
                        _context.Employees.Update(employee);
                        _context.SaveChanges();
                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên không tồn tại!");
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

                var employee = _context.Employees.Find(employeeID);
                if (employee != null)
                {
                    employee.Name = employeeName;
                    employee.Phone = phone;
                    employee.Email = email;
                    employee.AmountWage = amountWage;
                    employee.Position = position;
                    _context.Employees.Update(employee);
                    _context.SaveChanges();
                    LoadEmployees();
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ManageEployee_Load(object sender, EventArgs e)
        {
            //txtID.Enabled = false;
            //btnUpdate.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!ValidateInput(txtPhoneNum.Text))
            {
                return;
            }

            //int employeeID = int.Parse(txtID.Text);
            string employeeName = txtName.Text;
            string phone = txtPhoneNum.Text;
            string email = txtEmail.Text;
            decimal amountWage = decimal.Parse(txtWage.Text);
            string position = cmbPosition.Text;

            int id = _context.Employees.Where(e => e.Phone == phone).Select(e => e.Id).FirstOrDefault();


            // Gọi hàm EditEmployee để cập nhật vào database
            EditEmployee(id, employeeName, phone, email, amountWage, position);
            LoadEmployees();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            Clear_Texbox();
        }

        private void Clear_Texbox()
        {
            // Xóa hoặc đặt lại các ô nhập liệu
            //txtID.Clear();
            txtName.Clear();
            txtPhoneNum.Clear();
            txtEmail.Clear();
            txtWage.Clear();
            cmbPosition.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            Clear_Texbox();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                // Sửa tên cột từ "EmployeeId" thành "Id"
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                //int employeeID = (int)row.Cells["Id"].Value;
                string employeeName = row.Cells[1].Value.ToString();
                string phone = row.Cells[2].Value.ToString();
                string email = row.Cells[3].Value.ToString();
                decimal amountWage = (decimal)row.Cells[4].Value;
                string position = row.Cells[5].Value.ToString();

                //txtID.Text = employeeID.ToString();
                txtName.Text = employeeName;
                txtPhoneNum.Text = phone;
                txtEmail.Text = email;
                txtWage.Text = amountWage.ToString();
                cmbPosition.Text = position;

                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
                //btnEdit.Visible = false;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show($"Xác nhận xóa nhân viên {dgvEmployee.SelectedRows[0].Cells[1].Value.ToString()} ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Get phone from data grid view
                    string phone = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();


                    RemoveEmployee(phone);
                }
            }
        }

        private void dgvEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvEmployee.HitTest(e.X, e.Y);

                if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
                {
                    dgvEmployee.ClearSelection();
                    dgvEmployee.Rows[hit.RowIndex].Selected = true;

                    contextMenuStrip1.Show(dgvEmployee, e.Location);
                }
            }

        }

        //private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Kiểm tra nếu không phải dòng dữ liệu hợp lệ
        //    if (e.RowIndex < 0 || e.RowIndex >= dgvEmployee.Rows.Count || dgvEmployee.Rows[e.RowIndex].Cells["Id"].Value == null)
        //        return;

        //    try
        //    {
        //        // Lấy dòng hiện tại từ DataGridView
        //        DataGridViewRow selectedRow = dgvEmployee.Rows[e.RowIndex];

        //        // Gán dữ liệu từ dòng vào các TextBox
        //        txtID.Text = selectedRow.Cells["Id"].Value.ToString();
        //        txtName.Text = selectedRow.Cells["Name"].Value.ToString();
        //        txtPhoneNum.Text = selectedRow.Cells["Phone"].Value.ToString();
        //        txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
        //        txtWage.Text = selectedRow.Cells["AmountWage"].Value.ToString();
        //        cmbPosition.Text = selectedRow.Cells["Position"].Value.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Có lỗi xảy ra khi hiển thị dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
