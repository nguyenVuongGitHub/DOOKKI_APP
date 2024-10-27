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
                             join o in _context.Orders on od.OrderId equals o.OrderId
                             join t in _context.Tickets on od.TicketId equals t.TicketId
                             join p in _context.Payments on od.PaymentId equals p.PaymentId
                             join pm in _context.PaymentMethods on p.PaymentMethodId equals pm.PaymentMethodId
                             where o.OrderId == order.OrderId
                             select new
                             {
                                 Ticket = t,
                                 Payment = p,
                                 PaymentMethod = pm,
                                 OrderDetail = od,
                             }).ToList();

                /** why query.ElementAt(0) ?????
                 * because, in the order have many orderDetails, 
                 * and each orderDetail has one Payment. 
                 * and Payment has one PaymentMethod
                 * => just select one element in query when you want to access to Payment or PaymentMethod
                 */

                document.Replace("{EmployeeName}", "VuongDeptrai", false, true);
                document.Replace("{Date}", query.ElementAt(0).Payment.Day.ToString(), false, true);
                document.Replace("{CustomerName}", order?.Customer?.CustomerName ?? string.Empty, false, true);
                document.Replace("{PaymentMethod}", query.ElementAt(0).PaymentMethod.PaymentMethodName, false, true);

                string orderDetailsText = string.Empty;
                decimal totalBill = 0;

                foreach (var item in query)
                {
                    // follow with format Template.
                    orderDetailsText += $"{item.Ticket.TicketName}\t\t\t\t\t\t{item.OrderDetail.Quantily}\t\t{item.Ticket.TicketPrice}\n\t";
                    totalBill += item.Ticket.TicketPrice * item.OrderDetail.Quantily;
                }
                document.Replace("{OrderDetails}", orderDetailsText, false, true);


                document.Replace("{Amount}", $"{query.ElementAt(0).Payment.Amount}", false, true);
                decimal change = query.ElementAt(0).Payment.Amount - totalBill;

                document.Replace("Change", $"{change}", false, true);
                document.Replace("{TotalBill}", $"{totalBill}", false, true);

                string outputFilePath = Path.Combine(OutputFileDirectory, "Bill_" + order?.OrderId + ".pdf");
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
                            join w in _context.DayWorks on e.EmployeeId equals w.EmployeeId
                            where w.Day.Value.Month == selectedMonth &&
                                  w.Day.Value.Year == selectedYear
                            group w by new { e.EmployeeId, e.EmployeeName, e.AmountWage} into g
                            select new
                            {
                                EmployeeID = g.Key.EmployeeId,
                                Name = g.Key.EmployeeName,
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
    }
}
