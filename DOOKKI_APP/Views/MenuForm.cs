using DOOKKI_APP.Controllers;
using DOOKKI_APP.Models.Entities;
using DOOKKI_APP.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DOOKKI_APP.Views
{
    public partial class MenuForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly TicketController _ticketController;
        private TableForm tableForm;
        public MenuForm(DookkiContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _ticketController = new TicketController(context);
            _serviceProvider = serviceProvider;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtDate.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy", new System.Globalization.CultureInfo("en-US"));
            tableForm = new TableForm();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbTable.Items.Clear();

            List<string> availableTables = tableForm.GetAvailableTables();
            cbTable.Items.AddRange(availableTables.ToArray());
        }

        private void LoadDataGridView()
        {
            try
            {
                dgvTicket.AutoGenerateColumns = false;
                dgvTicket.AllowUserToResizeColumns = false;
                dgvTicket.AllowUserToResizeRows = false;

                dgvTicket.Columns.Clear();
                dgvTicket.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT" });
                dgvTicket.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "Name" });
                dgvTicket.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá", DataPropertyName = "Price" });

                _ticketController.DisplayToGirdView(dgvTicket);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at class Menu(Form) function LoadDataGridView " + ex.Message);
            }
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get data
                var ticketName = dgvTicket.Rows[e.RowIndex].Cells[1].Value.ToString();
                var price = Convert.ToDecimal(dgvTicket.Rows[e.RowIndex].Cells[2].Value);

                // Check ticket available
                var existingTicket = flowLayoutPanel1.Controls
                    .OfType<ucTicketDetail>()
                    .FirstOrDefault(ctrl => ctrl.ticketName == ticketName);

                if (existingTicket != null)
                {
                    existingTicket.ticketQuantity++;
                }
                else
                {
                    var ticketControl = new ucTicketDetail
                    {
                        ticketName = ticketName,
                        ticketPrice = price,
                        ticketQuantity = 1
                    };
                    flowLayoutPanel1.Controls.Add(ticketControl);
                }
            }
        }

        private void btnCooking_Click(object sender, EventArgs e)
        {
            string selectedTable = cbTable.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Vui lòng chọn một bàn trống.");
                return;
            }

            tableForm.BookTableByName(selectedTable);
            flowLayoutPanel1.Controls.Clear();
            cbTable.Items.Remove(selectedTable);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
