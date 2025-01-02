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
    public partial class InputCustomer : Form
    {
        private readonly CustomerController customerController;
        private readonly AccountController accountController;
        public InputCustomer(DookkiContext context)
        {
            InitializeComponent();
            customerController = new CustomerController(context);
            accountController = new AccountController(context);
            ShareData.IsInputCustomerFormClosed = false;
        }
        private bool IsValid()
        {
            bool isValid = true;
            if(string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtPhone, "Số điện thoại không được để trống.");
            }else
            {
                string phoneTest = "";
                phoneTest = txtPhone.Text;
                
                bool test = customerController.GetModel().Any(t => t.Phone == phoneTest);
                if (test)
                {
                    isValid = false;
                    errorProvider1.SetError(txtPhone, "Số điện thoại đã tồn tại.");
                }
            }
            return isValid;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newcus = new Customer();
                Account newacc = new Account();
                if(IsValid())
                {
                    newacc.UserName = txtPhone.Text;
                    newacc.Password = "1";
                    newacc.Role = "customer";
                    accountController.Add(newacc);
                    accountController.SaveChanges();
                    ShareData.CustomerPhoneNumber = txtPhone.Text;

                    newcus.Name = txtName.Text;
                    newcus.Idaccount = newacc.Id;
                    newcus.Phone = txtPhone.Text;
                    customerController.Add(newcus);
                    customerController.SaveChanges();

                    MessageBox.Show("Tạo tài khoản thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void InputCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShareData.IsInputCustomerFormClosed = true;
        }
    }
}
