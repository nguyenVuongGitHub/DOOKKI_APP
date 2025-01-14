﻿using DOOKKI_APP.Controllers;
using DOOKKI_APP.Helpers;
using DOOKKI_APP.Models.Entities;
using DOOKKI_APP.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private readonly int tableID;
        private readonly Size normalSizeForm = new Size(620, 505);
        private readonly Size expandSizeForm = new Size(988, 505);
        private int marks = 0;
        private decimal totalPrices;
        public PaymentForm(Order order, Payment payment, List<OrderDetail> orderDetails, DookkiContext context, int tableID, decimal totalPrice)
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
            this.tableID = tableID;
            this.totalPrices = totalPrice;
        }
        private bool IsValid()
        {
            bool isValid = true;
            if(!rdCash.Checked && !rdCredit.Checked)
            {
                isValid = false;
                errorProvider1.SetError(rdCash, "Chọn loại hình thanh toán");
                errorProvider1.SetError(rdCredit, "Chọn loại hình thanh toán");
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                isValid = false;

                errorProvider1.SetError(txtAmount, "Số tiền không được bỏ trống");
            }
            else
            {
                if (!decimal.TryParse(txtAmount.Text, out decimal amount) && amount <= 0)
                {
                    isValid = false;
                    errorProvider1.SetError(txtAmount, "Số tiền không đúng định dạng");
                }
            }
            if (ckbHadAccount.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCustomerPhone.Text))
                {
                    isValid = false;
                    errorProvider1.SetError(txtCustomerPhone, "Số điện thoại được bỏ trống");
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCustomerPhone.Text, @"^\d{10}$"))
                {
                    isValid = false;
                    errorProvider1.SetError(txtCustomerPhone, "Số điện thoại không hợp lệ");
                }
            }

            return isValid;
        }
        //private decimal TotalSum()
        //{
        //    decimal sum = 0;
        //    foreach (OrderDetail detail in orderDetails)
        //    {
        //        var price = (from t in ticketController.GetModel()
        //                     where t.Id == detail.TicketId
        //                     select t.Price).SingleOrDefault();

        //        sum += detail.Quantily * price;
        //    }
        //    return sum;
        //}
        private void UpdateMarkForCustomer()
        {


            // plus
            int totalSum = int.Parse(totalPrices.ToString());
            int cusId = customerController.GetModel().First(c => c.Phone == txtCustomerPhone.Text).Id;
            
            int pointsToAdd = totalSum / 300000;
            var cus = (from c in customerController.GetModel()
                       where c.Id == cusId
                       select c).SingleOrDefault();


            if (cus != null)
            {
                // minus
                if (cus.Marks >= marks)
                {
                    cus.Marks -= marks;
                }

                cus.Marks += pointsToAdd;
                customerController.Update(cus);
                customerController.SaveChanges();
            }
        }
        //private void UpdateValueOrder()
        //{
        //    try
        //    {
        //        if (order != null)
        //        {
        //            order.Time = TimeOnly.FromDateTime(DateTime.Now);
        //            var table = _context.Tables.FirstOrDefault(t => t.Id == tableID);


        //            table.Status = false;

        //            order.Discount = cbMarks.SelectedIndex;
        //            orderController.Add(order);
        //            orderController.SaveChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
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
                    orderDetailController.Update(orderDetail);
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
                if (IsValid())
                {
                    progressBar1.Visible = true;
                    backgroundWorker.RunWorkerAsync();
                }
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
            UpdateValueOrderDetail();
            backgroundWorker.ReportProgress(50);

            //UpdateValueOrder();
            int orderID = OrderControllerSingleton.Instance.GetIDUncheckOrderByTableID(tableID);
            order = OrderControllerSingleton.Instance.GetUncheckOrderByTableID(tableID);
            int customerID = 0;
            // had account
            if (ckbHadAccount.Checked)
            {
                string cusPhone = txtCustomerPhone.Text;

                int idCus = (from cus in customerController.GetModel()
                             where cus.Phone == cusPhone
                             select cus.Id).Single();
                customerID = idCus;
                backgroundWorker.ReportProgress(75);
                UpdateMarkForCustomer();
            }
            OrderControllerSingleton.Instance.CheckOut(orderID, tableID, totalPrices, customerID, marks);
            backgroundWorker.ReportProgress(90);
            if(export.ExportToPDF(order, marks))
            {

                backgroundWorker.ReportProgress(100);
            }else

            {
                MessageBox.Show("Loix");
            }
        }

        public event Action OnPaymentCompleted;

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Xuất bill thành công");
            //_manageOrders.TableOrders.Remove(ShareData.TableName);
            //_manageOrders.TableStatus[ShareData.TableName] = false; // Mark the original table as free
            //_tableForm.UpdateTableStatus(ShareData.TableName, false);
            //_tableForm.ClearTable();
            //ShareData.TableName = "";
           
            // reset table
            OnPaymentCompleted.Invoke(); // Invoke là khi sự kiện được gọi, nó sẽ kích hoạt tất cả các phương thức showorder và loadtable

            this.Close();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            //lblTotal.Text = "Tổng tiền: " + TotalSum().ToString("#,##0 VND");
            lblTotal.Text = "Tổng tiền: " + totalPrices.ToString();

            cbMarks.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
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
                txtAmount.Text = totalPrices.ToString();
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

        private void rdCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCredit.Checked)
            {
                if (txtAmount.Text.IsNullOrEmpty())
                {
                    return;
                }

                this.Size = expandSizeForm;

                int random = new Random().Next(0, 3 + 1);
                pictureBox1.Image = null;

                AdminBankAccount[] adminBankAccounts =
                {
                    new AdminBankAccount{accountName = "NGUYEN DINH VUONG", accountNumber = "104877403648", acqId ="970415"},
                    new AdminBankAccount{accountName = "NGUYEN TRAN CONG LY", accountNumber = "7621929005", acqId ="970418"},
                    new AdminBankAccount{accountName = "DUONG VO ANH TAI", accountNumber = "1027025103", acqId ="970436"},
                    new AdminBankAccount{accountName = "NGUYEN QUOC ANH", accountNumber = "7704205224100", acqId ="970405"}
                };
                AdminBankAccount theChosenOne = adminBankAccounts[random];
                string message = theChosenOne.HashMessage();

                VNpayPayment.Instance.CreatePaymentUrl(pictureBox1, theChosenOne.acqId, theChosenOne.accountNumber, theChosenOne.accountName, txtAmount.Text, message);
            }
            else
            {
                this.Size = normalSizeForm;
            }
        }

        private void cbMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            marks = cbMarks.SelectedIndex;
        }
    }
    internal class AdminBankAccount
    {
        public string accountName { get; set; }
        public string acqId { get; set; }
        public string accountNumber { get; set; }
        public string HashMessage()
        {
            int length = 10;
            StringBuilder hashMessage = new StringBuilder(length);
            Random random = new Random();
            string combined = accountName + acqId + accountNumber;
            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(0, combined.Length);
                hashMessage.Append(combined[randomIndex]);
            }
            
            return hashMessage.ToString();
        }
    }

}
