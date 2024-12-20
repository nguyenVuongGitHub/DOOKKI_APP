﻿using DOOKKI_APP.Controllers;
using DOOKKI_APP.Helpers;
using DOOKKI_APP.Models;
using DOOKKI_APP.Models.Entities;
using DOOKKI_APP.Views.UserControls;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class MainForm : Form
    {
        DookkiContext _context;
        IServiceProvider _serviceProvider;

        //Dictionary để lưu thông tin trạng thái từng bàn
        public Dictionary<string, bool> TableStatus { get; private set; } = new Dictionary<string, bool>();
        //Dictionary để lưu thông tin đặt hàng theo từng bàn
        public Dictionary<string, List<OrderInfo>> TableOrders { get; private set; } = new Dictionary<string, List<OrderInfo>>();
        public MainForm(DookkiContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            InitializeTableStatus();
            _context = context;
            _serviceProvider = serviceProvider;
            openChildForm(new TableForm(_context, this));
        }

        private Form currentFormChild;
        /// <summary>
        /// Form được tổ chức theo 1 form cha và các form con, MainForm là form cha
        /// </summary>
        /// <param name="childForm"> để hiện thị các form con vào phần body của form cha </param>
        public void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Khởi tạo 29 bàn + trạng thái các bàn là đang trống
        private void InitializeTableStatus()
        {
            for (int i = 1; i <= 29; i++)
            {
                string tableName = "Bàn " + i;
                TableStatus[tableName] = false;
            }
        }

        //Mở form con
        private void btnTable_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            openChildForm(new TableForm(_context, this));
        }

        //Mở form con
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            openChildForm(new ManageEployee(_context));
        }

        //Mở form con
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            if (User.Role == Roles.admin)
            {
                openChildForm(new ManageProducts(_context, _serviceProvider));
            }
            else

            {
                MessageBox.Show("Bạn ko có quyền truy cập vào đây", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Mở form con
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (User.Role == Roles.admin)
            {
                //openChildForm(new ManageProducts(context, _serviceProvider));
                //lblTitle.Text = btnTable.Text;
                MessageBox.Show("thong ke");
            }
            else

            {
                MessageBox.Show("Bạn ko có quyền truy cập vào đây", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Mở form con
        private void btnAdmin_Click(object sender, EventArgs e)
        {

            if (User.Role == Roles.admin)
            {
                openChildForm(new AccountManagement(_context));
            }
            else

            {
                MessageBox.Show("Bạn ko có quyền truy cập vào đây", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ CHẮC MUỐN ĐĂNG XUẤT KHÔNG!!!", "XÁC NHẬN", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var login = _serviceProvider.GetRequiredService<Login>();
                login.FormClosed += CloseMainForm; // khi form chính đóng sẽ gọi hàm này
                login.Show();
                this.Hide();
            }
        }

        private void ptbLogout2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ CHẮC MUỐN ĐĂNG XUẤT KHÔNG!!!", "XÁC NHẬN", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var login = _serviceProvider.GetRequiredService<Login>();
                login.FormClosed += CloseMainForm; // khi form chính đóng sẽ gọi hàm này
                login.Show();
                this.Hide();
            }
        }

        private void CloseMainForm(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login form when MainForm closes
        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                pnMenuContainer.Height += 10;
                if (pnMenuContainer.Height >= 135)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                pnMenuContainer.Height -= 10;
                if (pnMenuContainer.Height <= 40)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }
    }
}
