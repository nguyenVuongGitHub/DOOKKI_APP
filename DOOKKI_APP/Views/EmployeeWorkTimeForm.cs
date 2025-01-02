using DOOKKI_APP.Controllers;
using DOOKKI_APP.Models.Entities;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOOKKI_APP.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Globalization;


namespace DOOKKI_APP.Views
{
    public partial class EmployeeWorkTimeForm : Form
    {
        private readonly DookkiContext _context;

        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;

        public EmployeeWorkTimeForm()
        {
            InitializeComponent();
            _context = new DookkiContext();
            LoadEmployeeIDs();
            LoadWorkTimeData();
            InitializeFields();
        }

        private void LoadEmployeeIDs()
        {
            var employees = _context.Employees
            .OrderBy(e => e.Id)
            .Select(e => new
            {
                e.Id
            })
            .ToList();

            CmbEmployeeID.DataSource = employees;
            CmbEmployeeID.ValueMember = "Id";              
            CmbEmployeeID.DisplayMember = "Id";
        }
        private void InitializeFields()
        {
            cmbPageSize.SelectedIndex = 1;
            CmbEmployeeID.SelectedIndex = -1;
            cmbFilterMonth.SelectedIndex = 1;
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPhone.Text = string.Empty;
            dateTimePicker.Value = DateTime.Today;
        }


        private void LoadWorkTimeData()
        {
            var workTimeData = _context.DayWorks
            .Include(a => a.Employee)
            .AsEnumerable()
            .Select((dw, index) => new
            {
                STT = index + 1, // Calculating the row number
                ID = dw.Id,
                EmployeeName = dw.Employee.Name,
                Date = dw.Day,
                TotalTime = dw.TimeWork
            })
            .ToList();

            totalPages = (int)Math.Ceiling((double)workTimeData.Count / pageSize);

            var pagedData = workTimeData
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvWorkTime.Columns.Clear();
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã số ca", DataPropertyName = "ID" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "EmployeeName" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày", DataPropertyName = "Date" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian làm", DataPropertyName = "TotalTime" });

            dgvWorkTime.DataSource = pagedData;

            // Cập nhật nhãn hiển thị trang
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
        }


        private void ClearFields()
        {
            CmbEmployeeID.SelectedIndex = -1;
            txtName.Clear();
            txtPhone.Clear();
            txtTimeWork.Clear();
            dateTimePicker.Value = DateTime.Now;
            errorProviderTime.Clear();
            errorProviderDate.Clear();

        }
        private bool ValidateFields()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtTimeWork.Text) || !int.TryParse(txtTimeWork.Text, out int timeWork) || timeWork <= 0 || timeWork >= 24)
            {
                errorProviderTime.SetError(txtTimeWork, "Vui lòng nhập thời gian làm việc hợp lệ (số nguyên dương bé hơn 24 giờ 1 ngày).");
                isValid = false;
            }
            else
            {
                errorProviderTime.SetError(txtTimeWork, string.Empty);
            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider.SetError(txtName, "Tên không được để trống.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtPhone.Text.Trim()) || !txtPhone.Text.All(char.IsDigit))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại phải là số và không được để trống.");
                isValid = false;
            }

            if (CmbEmployeeID.SelectedItem == null)
            {
                errorProvider.SetError(CmbEmployeeID, "Vui lòng chọn một nhân viên.");
                isValid = false;
            }

            return isValid;
        }
        private void EmployeeWorkTimeForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeWorkTimeForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWorkTime_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            if (CmbEmployeeID.SelectedItem == null || string.IsNullOrEmpty(txtTimeWork.Text))
            {
                return;
            }

            var newWorkTime = new DayWork
            {
                TimeWork = int.Parse(txtTimeWork.Text),
                Day = DateOnly.FromDateTime(dateTimePicker.Value),
                EmployeeId = int.Parse(CmbEmployeeID.SelectedValue.ToString())
            };

            _context.DayWorks.Add(newWorkTime);
            _context.SaveChanges();

            MessageBox.Show("Đã thêm thời gian làm việc thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWorkTimeData();
            ClearFields();

        }

        private void btnUpdateWorkTime_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            if (dgvWorkTime.CurrentRow == null)
            {
                return;
            }

            DataGridViewRow selectedRow = dgvWorkTime.SelectedRows[0];

            var id = int.Parse(selectedRow.Cells[1].Value.ToString());
            var workTime = _context.DayWorks.FirstOrDefault(dw => dw.Id == id);

            if (workTime != null)
            {
                workTime.TimeWork = int.Parse(txtTimeWork.Text);
                workTime.Day = DateOnly.FromDateTime(dateTimePicker.Value);
                workTime.EmployeeId = int.Parse(CmbEmployeeID.SelectedValue.ToString());

                _context.SaveChanges();
                MessageBox.Show("Thời gian làm việc được cập nhật thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWorkTimeData();
                ClearFields();
                btnUpdateWorkTime.Enabled = false;
            }
        }

        private void btnDeleteWorkTime_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            if (dgvWorkTime.CurrentRow == null)
            {
                return;
            }


        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        var worksheet = package.Workbook.Worksheets.First();
                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;

                        // Lấy ngày đầu tuần từ tiêu đề cột
                        var startDate = DateTime.Parse(worksheet.Cells[1, 4].Value.ToString().Split('(')[1].TrimEnd(')'));

                        for (int row = 2; row <= rowCount; row++)
                        {
                            int employeeId = int.Parse(worksheet.Cells[row, 1].Value.ToString());

                            for (int i = 0; i < 7; i++)
                            {
                                var day = DateOnly.FromDateTime(startDate.AddDays(i));
                                var timeWork = int.Parse(worksheet.Cells[row, 4 + i].Value.ToString());

                                if (timeWork > 0)
                                {
                                    if (!_context.DayWorks.Any(dw => dw.EmployeeId == employeeId && dw.Day == day))
                                    {
                                        var newWorkTime = new DayWork
                                        {
                                            EmployeeId = employeeId,
                                            Day = day,
                                            TimeWork = timeWork
                                        };
                                        _context.DayWorks.Add(newWorkTime);
                                    }
                                }
                            }
                        }

                        _context.SaveChanges();
                        MessageBox.Show("Nhập dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadWorkTimeData();
                    }
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            var exf = new ExportFile(_context);
            exf.ExportWorkTime(dateTimePicker);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadWorkTimeData();
            }
        }

        private void btn_foward_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadWorkTimeData();
            }
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbPageSize.SelectedItem.ToString(), out int newPageSize))
            {
                pageSize = newPageSize;
                currentPage = 1; // Reset về trang đầu
                LoadWorkTimeData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var workTimeData = _context.DayWorks
                .Include(a => a.Employee)
                .AsEnumerable()
                .Select((dw, index) => new
                {
                    STT = index + 1, // Calculating the row number
                    ID = dw.Id,
                    EmployeeName = dw.Employee.Name,
                    Date = dw.Day,
                    TotalTime = dw.TimeWork
                })
                .ToList();



            workTimeData = workTimeData
                .Where(dw => dw.EmployeeName.ToLower().Contains(keyword))
                .ToList();

            totalPages = (int)Math.Ceiling((double)workTimeData.Count / pageSize);

            var pagedData = workTimeData
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvWorkTime.Columns.Clear();
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã số ca", DataPropertyName = "ID" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "EmployeeName" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày", DataPropertyName = "Date" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian làm", DataPropertyName = "TotalTime" });

            dgvWorkTime.DataSource = pagedData;

            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
        }

        private void cmbFilterMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var workTimeData = _context.DayWorks
            .Include(a => a.Employee)
            .AsEnumerable()
            .Select((dw, index) => new
            {
                STT = index + 1, // Calculating the row number
                ID = dw.Id,
                EmployeeName = dw.Employee.Name,
                Date = dw.Day,
                TotalTime = dw.TimeWork
            })
            .ToList();

            if (cmbFilterMonth.SelectedItem.ToString() == "Hôm nay")
            {
                workTimeData = workTimeData
                    .Where(dw => dw.Date.HasValue && dw.Date.Value == DateOnly.FromDateTime(DateTime.Today))
                    .ToList();
                txtDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            }
            else if (cmbFilterMonth.SelectedItem.ToString() == "Tất cả")
            {
                workTimeData = workTimeData.ToList();
                txtDate.Text = "Tất cả các ngày";
            }
            else
            {
                int month = cmbFilterMonth.SelectedIndex - 1;
                workTimeData = workTimeData
                    .Where(dw => dw.Date.HasValue && dw.Date.Value.Month == month)
                    .ToList();
                txtDate.Text = $"{new DateTime(DateTime.Now.Year, month, 1).ToString("dd/MM/yyyy")} - {new DateTime(DateTime.Now.Year, month, DateTime.DaysInMonth(DateTime.Now.Year, month)).ToString("dd/MM/yyyy")}";
            }
            if(workTimeData.Count <=0)
            {
                currentPage = 0;
            }
            else
            {
                currentPage = 1;
            }
            totalPages = (int)Math.Ceiling((double)workTimeData.Count / pageSize);

            var pagedData = workTimeData
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvWorkTime.Columns.Clear();
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã số ca", DataPropertyName = "ID" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "EmployeeName" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày", DataPropertyName = "Date" });
            dgvWorkTime.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian làm", DataPropertyName = "TotalTime" });

            dgvWorkTime.DataSource = pagedData;
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEmployeeID.SelectedItem != null)
            {
                Console.WriteLine($"Selected Employee ID: {CmbEmployeeID.SelectedValue}");
                int employeeID = int.Parse(CmbEmployeeID.SelectedValue.ToString());
                var employee = _context.Employees.FirstOrDefault(e => e.Id == employeeID);

                if (employee != null)
                {
                    FillEmployeeDetails(employee);
                }
                else
                {
                    ClearAllFields();
                }
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            string inputName = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputName))
            {
                ClearAllFields();
                return;
            }

            // Tìm nhân viên theo Name
            var employee = _context.Employees.FirstOrDefault(e => e.Name.ToLower() == inputName.ToLower());
            if (employee != null)
            {
                FillEmployeeDetails(employee);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với tên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAllFields();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string inputPhone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputPhone))
            {
                ClearAllFields();
                return;
            }

            // Tìm nhân viên theo Phone
            var employee = _context.Employees.FirstOrDefault(e => e.Phone.ToLower() == inputPhone.ToLower());
            if (employee != null)
            {
                FillEmployeeDetails(employee);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAllFields();
            }
        }

        private void FillEmployeeDetails(Employee employee)
        {
            CmbEmployeeID.SelectedValue = employee.Id;
            txtName.Text = employee.Name;
            txtPhone.Text = employee.Phone;
        }

        private void ClearAllFields()
        {
            CmbEmployeeID.SelectedIndex = -1;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            if (dgvWorkTime.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvWorkTime.SelectedRows[0];
                var id = int.Parse(selectedRow.Cells[1].Value.ToString());
                var workTime = _context.DayWorks.FirstOrDefault(dw => dw.Id == id);

                _context.DayWorks.Remove(workTime);
                _context.SaveChanges();

                MessageBox.Show("Đã xóa thời gian làm việc thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWorkTimeData();
                ClearFields();
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvWorkTime.SelectedRows.Count > 0)
            {
                btnUpdateWorkTime.Enabled = true;
                DataGridViewRow selectedRow = dgvWorkTime.SelectedRows[0];

                txtName.Text = selectedRow.Cells[2].Value.ToString();
                dateTimePicker.Value = DateTime.Parse(selectedRow.Cells[3].Value?.ToString());
                txtTimeWork.Text = selectedRow.Cells[4].Value.ToString();

                var id = int.Parse(selectedRow.Cells[1].Value.ToString());
                var workTime = _context.DayWorks.FirstOrDefault(dw => dw.Id == id);
                var employee = _context.Employees.FirstOrDefault(s => s.Id == workTime.EmployeeId);
                CmbEmployeeID.SelectedValue = employee.Id;
                txtPhone.Text = employee.Phone;

            }
        }

        private void dgvWorkTime_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvWorkTime.HitTest(e.X, e.Y);

                if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
                {
                    dgvWorkTime.ClearSelection();
                    dgvWorkTime.Rows[hit.RowIndex].Selected = true;

                    contextMenuStrip1.Show(dgvWorkTime, e.Location);
                }
            }
        }
    }
}
