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
            var employeeIDs = _context.Employees.Select(e => e.Id).ToList();
            CmbEmployeeID.DataSource = employeeIDs;
        }
        private void InitializeFields()
        {
                CmbEmployeeID.SelectedIndex = -1;
                txtName.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtPosition.Text = string.Empty;
        }


        private void LoadWorkTimeData()
        {
            var workTimeData = _context.DayWorks
                .Select(dw => new
                {
                    dw.Id,
                    dw.TimeWork,
                    dw.Day,
                    EmployeeName = dw.Employee.Name
                })
                .ToList();

            // Tính tổng số trang
            totalPages = (int)Math.Ceiling((double)workTimeData.Count / pageSize);

            // Lấy dữ liệu cho trang hiện tại
            var pagedData = workTimeData
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvWorkTime.DataSource = pagedData;

            // Cập nhật nhãn hiển thị trang
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
        }


        private void ClearFields()
        {
            CmbEmployeeID.SelectedIndex = -1;
            txtName.Clear();
            txtPhone.Clear();
            txtPosition.Clear();
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

            if (CmbEmployeeID.SelectedItem != null)
            {
                int employeeID = int.Parse(CmbEmployeeID.SelectedItem.ToString());
                var existingDayWork = _context.DayWorks.FirstOrDefault(dw =>
                    dw.EmployeeId == employeeID && dw.Day == DateOnly.FromDateTime(dateTimePicker.Value));

                if (existingDayWork != null)
                {
                    errorProviderDate.SetError(dateTimePicker, "Ngày đã chọn đã được ghi lại cho nhân viên này.");
                    isValid = false;
                }
                else
                {
                    errorProviderDate.SetError(dateTimePicker, string.Empty);
                }
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
                EmployeeId = int.Parse(CmbEmployeeID.SelectedItem.ToString())
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

            int id = (int)dgvWorkTime.CurrentRow.Cells["ID"].Value;
            var workTime = _context.DayWorks.FirstOrDefault(dw => dw.Id == id);

            if (workTime != null)
            {
                workTime.TimeWork = int.Parse(txtTimeWork.Text);
                workTime.Day = DateOnly.FromDateTime(dateTimePicker.Value);
                workTime.EmployeeId = int.Parse(CmbEmployeeID.SelectedItem.ToString());

                _context.SaveChanges();
                MessageBox.Show("Thời gian làm việc được cập nhật thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWorkTimeData();
                ClearFields();

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

            int id = (int)dgvWorkTime.CurrentRow.Cells["ID"].Value;
            var workTime = _context.DayWorks.FirstOrDefault(dw => dw.Id == id);

            if (workTime != null)
            {
                _context.DayWorks.Remove(workTime);
                _context.SaveChanges();

                MessageBox.Show("Đã xóa thời gian làm việc thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWorkTimeData();
                ClearFields();

            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("WorkTimeSchedule");

                        // Tiêu đề cột
                        worksheet.Cells[1, 1].Value = "Employee ID";
                        worksheet.Cells[1, 2].Value = "Name";
                        worksheet.Cells[1, 3].Value = "Time Worked";

                        // Lấy ngày từ DateTimePicker và tính ngày đầu tuần (Thứ Hai)
                        var selectedDate = dateTimePicker.Value;
                        var startDate = selectedDate.StartOfWeek(DayOfWeek.Monday);

                        // Thêm tiêu đề cột cho từng ngày trong tuần
                        for (int i = 0; i < 7; i++)
                        {
                            var date = startDate.AddDays(i);
                            worksheet.Cells[1, 4 + i].Value = $"{date:dddd} ({date:yyyy-MM-dd})";
                        }

                        // Lấy dữ liệu từ cơ sở dữ liệu
                        var employees = _context.Employees.ToList();
                        int row = 2;

                        foreach (var employee in employees)
                        {
                            worksheet.Cells[row, 1].Value = employee.Id;
                            worksheet.Cells[row, 2].Value = employee.Name;

                            // Tính tổng số giờ làm việc trong tuần
                            var totalTime = _context.DayWorks
                                .Where(dw => dw.EmployeeId == employee.Id && dw.Day >= DateOnly.FromDateTime(startDate) && dw.Day <= DateOnly.FromDateTime(startDate.AddDays(6)))
                                .Sum(dw => dw.TimeWork);

                            worksheet.Cells[row, 3].Value = totalTime;

                            // Thêm giờ làm việc cho từng ngày trong tuần
                            for (int i = 0; i < 7; i++)
                            {
                                var date = DateOnly.FromDateTime(startDate.AddDays(i));
                                var timeWorked = _context.DayWorks
                                    .FirstOrDefault(dw => dw.EmployeeId == employee.Id && dw.Day == date)?.TimeWork ?? 0;

                                worksheet.Cells[row, 4 + i].Value = timeWorked;
                            }

                            row++;
                        }

                        // Lưu file Excel
                        package.SaveAs(new FileInfo(filePath));
                        MessageBox.Show("Xuất dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
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
                .Select(dw => new
                {
                    dw.Id,
                    dw.TimeWork,
                    dw.Day,
                    EmployeeName = dw.Employee.Name
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

            dgvWorkTime.DataSource = pagedData;

            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
        }

        private void cmbFilterMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var workTimeData = _context.DayWorks
        .Select(dw => new
        {
            dw.Id,
            dw.TimeWork,
            dw.Day,
            EmployeeName = dw.Employee.Name
        })
        .ToList();

            if (cmbFilterMonth.SelectedItem.ToString() == "Hôm nay")
            {
                workTimeData = workTimeData
                    .Where(dw => dw.Day.HasValue && dw.Day.Value == DateOnly.FromDateTime(DateTime.Today))
                    .ToList();
            }
            else
            {
                int month = cmbFilterMonth.SelectedIndex;
                workTimeData = workTimeData
                    .Where(dw => dw.Day.HasValue && dw.Day.Value.Month == month)
                    .ToList();
            }

            totalPages = (int)Math.Ceiling((double)workTimeData.Count / pageSize);

            var pagedData = workTimeData
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvWorkTime.DataSource = pagedData;

            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEmployeeID.SelectedItem != null)
            {
                int employeeID = int.Parse(CmbEmployeeID.SelectedItem.ToString());
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
            CmbEmployeeID.SelectedItem = employee.Id;
            txtName.Text = employee.Name;
            txtPhone.Text = employee.Phone;
            txtPosition.Text = employee.Position;
        }

        private void ClearAllFields()
        {
            CmbEmployeeID.SelectedIndex = -1; // Làm trống ComboBox
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPosition.Text = string.Empty;
        }
    }
}
