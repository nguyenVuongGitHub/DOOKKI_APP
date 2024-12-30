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
using DOOKKI_APP.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using DOOKKI_APP.Helpers;

namespace DOOKKI_APP.Views
{
    public partial class Login : Form
    {
        private readonly AccountController _accountController;
        private readonly AdminController _adminController;
        private readonly EmployeeController _employeeController;
        private readonly IServiceProvider _serviceProvider;
        public Login(DookkiContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _accountController = new AccountController(context);
            _adminController = new AdminController(context);
            _employeeController = new EmployeeController(context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;

                if (userName.IsNullOrEmpty() || password.IsNullOrEmpty())
                {
                    return;
                }

                var checkLogin = (from c in _accountController.GetModel()
                                  where c.UserName == userName && c.Password == password
                                  select c).SingleOrDefault();

                if (checkLogin == null)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai");
                }
                else
                {
                    // set role for user.
                    User.SetRoles(checkLogin.Role);
                    string? username = checkLogin.UserName;
                    string? name = "";

                    if (User.Role == Roles.admin)
                    {
                        name = (from ad in _adminController.GetModel()
                                    where ad.Idaccount == checkLogin.Id
                                    select ad.Name).SingleOrDefault();
                    }
                    else if (User.Role == Roles.employee)
                    {
                        name = (from em in _employeeController.GetModel()
                                    where em.Phone == checkLogin.UserName
                                    select em.Name).SingleOrDefault();
                        
                    }
                    if (username != null && name != null)
                    {
                        User.Name = name;
                        User.Username = username;
                    }
                    //move on to another form

                    var mainForm = _serviceProvider.GetRequiredService<EmployeeWorkTimeForm>();
                    mainForm.FormClosed += CloseLoginForm; // khi form chính đóng sẽ gọi hàm này
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at class Login(Form) and function btnLogin_Click : {ex.Message}");
            }


        }
        private void CloseLoginForm(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login form when MainForm closes
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        
    }
}
