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


namespace DOOKKI_APP.Views
{
    public partial class EmployeeWorkTimeForm : Form
    {
        private readonly DookkiContext _context;

        public EmployeeWorkTimeForm()
        {
            InitializeComponent();
            _context = new DookkiContext();
            LoadEmployeeIDs();
            LoadWorkTimeData();
        }

        private void LoadEmployeeIDs()
        {
            var employeeIds = _context.Employees.Select(e => e.Id).ToList();
            cmbEmployeeID.Items.Clear();
            cmbEmployeeID.Items.AddRange(employeeIds.Cast<object>().ToArray());
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

            dgvWorkTime.DataSource = workTimeData;
        }
        private void ClearFields()
        {
            cmbEmployeeID.SelectedIndex = -1;
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

            if (string.IsNullOrEmpty(txtTimeWork.Text) || !int.TryParse(txtTimeWork.Text, out int timeWork) || timeWork <= 0)
            {
                errorProviderTime.SetError(txtTimeWork, "Vui lòng nhập thời gian làm việc hợp lệ (số nguyên dương).");
                isValid = false;
            }
            else
            {
                errorProviderTime.SetError(txtTimeWork, string.Empty);
            }

            if (cmbEmployeeID.SelectedItem != null)
            {
                int employeeID = int.Parse(cmbEmployeeID.SelectedItem.ToString());
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

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedItem != null)
            {
                int employeeID = int.Parse(cmbEmployeeID.SelectedItem.ToString());
                var employee = _context.Employees.FirstOrDefault(e => e.Id == employeeID);

                if (employee != null)
                {
                    txtName.Text = employee.Name;
                    txtPhone.Text = employee.Phone;
                    txtPosition.Text = employee.Position;
                }
            }
        }

        private void btnAddWorkTime_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            if (cmbEmployeeID.SelectedItem == null || string.IsNullOrEmpty(txtTimeWork.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên và nhập thời gian làm việc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newWorkTime = new DayWork
            {
                TimeWork = int.Parse(txtTimeWork.Text),
                Day = DateOnly.FromDateTime(dateTimePicker.Value),
                EmployeeId = int.Parse(cmbEmployeeID.SelectedItem.ToString())
            };

            _context.DayWorks.Add(newWorkTime);
            _context.SaveChanges();

            MessageBox.Show("Đã thêm thời gian làm việc thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWorkTimeData();
            ClearFields();

        }

        private void btnUpdateWorkTime_Click(object sender, EventArgs e)
        {
            if (dgvWorkTime.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = (int)dgvWorkTime.CurrentRow.Cells["ID"].Value;
            var workTime = _context.DayWorks.FirstOrDefault(dw => dw.Id == id);

            if (workTime != null)
            {
                workTime.TimeWork = int.Parse(txtTimeWork.Text);
                workTime.Day = DateOnly.FromDateTime(dateTimePicker.Value);
                workTime.EmployeeId = int.Parse(cmbEmployeeID.SelectedItem.ToString());

                _context.SaveChanges();
                MessageBox.Show("Thời gian làm việc được cập nhật thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWorkTimeData();
                ClearFields();

            }
        }

        private void btnDeleteWorkTime_Click(object sender, EventArgs e)
        {
            if (dgvWorkTime.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một bản ghi để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        private void importToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
