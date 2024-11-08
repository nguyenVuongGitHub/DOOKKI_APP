using DOOKKI_APP.Controllers;
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
    public partial class PaymentForm : Form
    {
        private Order order;
        private Payment payment;
        private List<OrderDetail> orderDetails;
        private readonly AccountController accountController;
        private readonly CustomerController customerController;
        private readonly PaymentController paymentController;
        private readonly OrderController orderController;
        private readonly OrderDetailController orderDetailController;
        private readonly TicketController ticketController;
        private readonly ExportFile export;
        private readonly DookkiContext _context;
        public PaymentForm(Order order, Payment payment, List<OrderDetail> orderDetails, DookkiContext context)
        {
            InitializeComponent();
            this.order = order;
            this.payment = payment;
            this.orderDetails = orderDetails;
            accountController = new AccountController(context);
            customerController = new CustomerController(context);
            paymentController = new PaymentController(context);
            orderController = new OrderController(context);
            orderDetailController = new OrderDetailController(context);
            export = new ExportFile(context);
            ticketController = new TicketController(context);
            _context = context;

        }
        public PaymentForm(DookkiContext context)
        {
            InitializeComponent();
            // get data
            order = new Order();
            payment = new Payment();
            orderDetails = new List<OrderDetail>();
            accountController = new AccountController(context);
            customerController = new CustomerController(context);
            paymentController = new PaymentController(context);
            orderController = new OrderController(context);
            orderDetailController = new OrderDetailController(context);
            export = new ExportFile(context);
            ticketController = new TicketController(context);
            _context = context;


        }
        private decimal TotalSum()
        {
            decimal sum = 0;
            foreach (OrderDetail detail in orderDetails)
            {
                var price = (from t in ticketController.GetModel()
                             where t.Id == detail.TicketId
                             select t.Price).SingleOrDefault();

                sum += detail.Quantily * price;
            }
            return sum;
        }
        private void UpdateMarkForCustomer()
        {
            

            // plus
            int totalSum = int.Parse(TotalSum().ToString());
            int cusId = (from c in customerController.GetModel()
                         where c.Id == order.CustomerId
                         select c.Id).SingleOrDefault();

            int pointsToAdd = totalSum / 300000;
            var cus = (from c in customerController.GetModel()
                       where c.Id == cusId
                       select c).SingleOrDefault();
            

            if (cus != null)
            {
                // minus
                if (order.Discount > 0 && cus.Marks > order.Discount)
                {
                    cus.Marks -= order.Discount;
                }

                cus.Marks += pointsToAdd;
                customerController.Update(cus);
                customerController.SaveChanges();
            }
        }
        private void UpdateValueOrder()
        {
            try
            {
                if (order != null)
                {
                    order.Time = TimeOnly.FromDateTime(DateTime.Now);
                    // had account
                    if (ckbHadAccount.Checked)
                    {
                        string cusPhone = txtCustomerPhone.Text;

                        int? idCus = (from cus in customerController.GetModel()
                                      where cus.Phone == cusPhone
                                      select cus.Id).SingleOrDefault();

                        if (idCus != null)
                        {
                            order.CustomerId = idCus;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng");
                        }

                    }
                    else // no account
                    {
                        order.CustomerId = 0;
                    }
                    order.Discount = cbMarks.SelectedIndex;
                    orderController.Add(order);
                    orderController.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateValuePayment()
        {
            try
            {
                if (payment != null)
                {

                    if (rdCredit.Checked)
                    {
                        payment.PaymentMethodId = 1;
                    }
                    else if (rdCash.Checked)
                    {
                        payment.PaymentMethodId = 2;
                    }
                    payment.Day = DateOnly.FromDateTime(DateTime.Now);
                    payment.Amount = decimal.Parse(txtAmount.Text);
                    paymentController.Add(payment);
                    paymentController.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateValueOrderDetail()
        {
            try
            {
                foreach (var orderDetail in orderDetails)
                {
                    orderDetail.PaymentId = payment.Id;
                    orderDetail.OrderId = order.Id;

                    orderDetailController.Add(orderDetail);
                }
                orderDetailController.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HideOrShowCustomerInput()
        {
            try
            {
                label4.Visible = !label4.Visible;
                txtCustomerPhone.Visible = !txtCustomerPhone.Visible;
                btnSearch.Visible = !btnSearch.Visible;
                if (ShareData.IsInputCustomerFormClosed)
                {
                    txtCustomerPhone.Text = ShareData.CustomerPhoneNumber;
                }
                if (!btnSearch.Visible)
                {
                    label1.Visible = false;
                    label6.Visible = false;
                    cbMarks.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                progressBar1.Visible = true;
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Đang xuất bill, vui lòng đợi...");
            }

        }

        private void cbHadAccount_CheckedChanged(object sender, EventArgs e)
        {
            HideOrShowCustomerInput();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateValuePayment();
            backgroundWorker.ReportProgress(25);
            UpdateValueOrder();
            backgroundWorker.ReportProgress(50);
            UpdateValueOrderDetail();
            backgroundWorker.ReportProgress(75);
            UpdateMarkForCustomer();
            backgroundWorker.ReportProgress(90);
            export.ExportToPDF(order);
            backgroundWorker.ReportProgress(100);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Xuất bill thành công");
            this.Close();
            MessageBox.Show("Cập nhật lại trạng thái bàn tại đây");
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "Tổng tiền: " + TotalSum().ToString("#,##0 VND");
            cbMarks.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = (from cus in customerController.GetModel()
                                where cus.Phone == txtCustomerPhone.Text
                                select cus).SingleOrDefault();
                if (customer != null)
                {
                    int? mark = customer.Marks;
                    label1.Visible = true;
                    label6.Visible = true;
                    label6.Text = $"Khách hàng có: {mark} điểm";
                    cbMarks.Visible = true;
                }
                else
                {
                    label1.Visible = false;
                    label6.Visible = false;
                    cbMarks.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTotal.Checked)
            {
                txtAmount.Text = TotalSum().ToString();
            }
            else
            {
                txtAmount.Text = "";
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Form inputCus = new InputCustomer(_context);
            inputCus.Show();
        }
    }
}
