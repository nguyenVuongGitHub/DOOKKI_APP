using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOKKI_APP.Models.Entities;
using Spire.Doc;
using System.IO;
using System.Diagnostics;

namespace DOOKKI_APP.Helpers
{
    internal class ExportFile
    {
        private string solutionDirectory;
        private string assetsDirectory;
        private string OutputFileDirectory;
        private string fileTemplateBill;
        private DookkiContext _context;
        public ExportFile(DookkiContext context)
        {
            // get direction of solution
            solutionDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            assetsDirectory = Path.Combine(solutionDirectory, "Assets");
            OutputFileDirectory = Path.Combine(solutionDirectory, "OutputFile");
            fileTemplateBill = Path.Combine(assetsDirectory, "Template", "Bill.docx");
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
                document.SaveToFile(outputFilePath, FileFormat.PDF);
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
        public void ExportToExcel()
        {

        }
        /// <summary>
        /// export company's income 
        /// </summary>
        public void ExportToDoc()
        {
        }
    }
}
