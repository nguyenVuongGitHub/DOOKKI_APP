using DOOKKI_APP.Helpers;
using DOOKKI_APP.Models.Entities;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DOOKKI_APP.Helpers.DashboardHelper;

namespace DOOKKI_APP.Views
{
    public partial class Dashboard : Form
    {
        private DashboardController _controller;
        private DookkiContext _context;
        private ExportFile export;
        public Dashboard(DookkiContext context)
        {
            InitializeComponent();
            _context = context;
            export = new ExportFile(_context);
            _controller = new DashboardController(_context);

            LoadComboBoxChoice();
            dtpFromDate.Value = new DateTime(DateTime.Today.Year - 1, 1, 1);
            dtpToDate.Value = new DateTime(DateTime.Today.Year - 1, 12, 31);

            LoadData();
        }

        private void LoadData()
        {
            bool refreshData = _controller.LoadData(dtpFromDate.Value, dtpToDate.Value);
            if (refreshData)
            {
                lbTotalRevenue.Text = _controller.totalRevenue.ToString("N0") + " đ";
                lbTotalCustomer.Text = _controller.numberCustomer.ToString("N0");
                lbTotalOrder.Text = _controller.numberOrder.ToString("N0");

                cRevenue.DataSource = _controller.GrossRevenueList;
                cRevenue.Series[0].XValueMember = "Date";
                cRevenue.Series[0].YValueMembers = "TotalAmount";
                cRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

                cRevenue.DataBind();

                dgvTopSeller.DataSource = _controller.TopProductList;
            }
        }
        private void LoadComboBoxChoice()
        {
            cbChoice.Items.Add("Custom");
            cbChoice.Items.Add("Today");
            cbChoice.Items.Add("Last 7 Days");
            cbChoice.Items.Add("This Month");
            cbChoice.Items.Add("This Year");
            cbChoice.Items.Add("Last Year");

            cbChoice.SelectedIndex = 5;
        }

        private void DisableCustomData()
        {
            dtpFromDate.Enabled = false;
            dtpToDate.Enabled = false;
            btnCheck.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(_controller.numberOrder == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            export.ExportDashboard(_controller, dtpFromDate.Value, dtpToDate.Value);
        }

        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoice.SelectedIndex == 0)
            {
                dtpFromDate.Enabled = true;
                dtpToDate.Enabled = true;
                btnCheck.Enabled = true;
            }
            else if (cbChoice.SelectedIndex == 1)
            {
                dtpFromDate.Value = DateTime.Today;
                dtpToDate.Value = DateTime.Now;
                LoadData();
                DisableCustomData();
            }
            else if (cbChoice.SelectedIndex == 2)
            {
                dtpFromDate.Value = DateTime.Today.AddDays(-7);
                dtpToDate.Value = DateTime.Now;
                LoadData();
                DisableCustomData();
            }
            else if (cbChoice.SelectedIndex == 3)
            {
                dtpFromDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtpToDate.Value = DateTime.Now;
                LoadData();
                DisableCustomData();
            }
            else if(cbChoice.SelectedIndex == 4)
            {
                dtpFromDate.Value = new DateTime(DateTime.Today.Year, 1, 1);
                dtpToDate.Value = new DateTime(DateTime.Today.Year, 12, 31);
                LoadData();
                DisableCustomData();
            }
            else
            {
                dtpFromDate.Value = new DateTime(DateTime.Today.Year-1, 1, 1);
                dtpToDate.Value = new DateTime(DateTime.Today.Year-1, 12, 31);
                LoadData();
                DisableCustomData();
            }
        }
    }
}
