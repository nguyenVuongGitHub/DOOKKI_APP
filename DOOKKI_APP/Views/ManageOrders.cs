using DOOKKI_APP.Controllers;
using DOOKKI_APP.Helpers;
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
    public partial class ManageOrders : Form
    {
        DookkiContext context = new DookkiContext(); 
        IServiceProvider serviceProvider;
        public ManageOrders()
        {
            InitializeComponent();
            openChildForm(new MenuForm(context, serviceProvider));
        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuForm(context, serviceProvider));
            lblTitle.Text = btnMenu.Text;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            openChildForm(new TableForm());
            lblTitle.Text = btnTable.Text;
        }
    }
}
