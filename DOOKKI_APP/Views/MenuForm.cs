using DOOKKI_APP.Controllers;
using DOOKKI_APP.Models;
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
        private ManageOrders _manageOrders;
        public MenuForm(DookkiContext context, IServiceProvider serviceProvider, ManageOrders manageOrders)
        {
            InitializeComponent();
            _ticketController = new TicketController(context);
            _serviceProvider = serviceProvider;
            _manageOrders = manageOrders;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtDate.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy", new System.Globalization.CultureInfo("en-US"));
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbTable.Items.Clear();

            // Lấy danh sách các bàn có trạng thái trống (IsOccupied = false) từ TableStatus
            foreach (var table in _manageOrders.TableStatus.Where(t => !t.Value))
            {
                cbTable.Items.Add(table.Key);
            }
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
                UpdateTotalSum();
            }
        }

        private void UpdateTotalSum()
        {
            decimal totalSum = flowLayoutPanel1.Controls
                .OfType<ucTicketDetail>()
                .Sum(ctrl => ctrl.ticketPrice * ctrl.ticketQuantity); // Calculate total price

            lblSum.Text = totalSum.ToString("#,##0 VND"); // Update lblSum
        }

        private void btnCooking_Click(object sender, EventArgs e)
        {
            var selectedTable = cbTable.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTable))
            {
                _manageOrders.TableStatus[selectedTable] = true; // Cập nhật trạng thái bàn thành đã đặt

                // Cập nhật các thông tin đặt hàng như trước (cập nhật các chi tiết vé đã chọn)
                var orderDetails = flowLayoutPanel1.Controls
                    .OfType<ucTicketDetail>()
                    .Select(ticketDetail => new OrderInfo
                    {
                        TicketName = ticketDetail.ticketName,
                        Quantity = ticketDetail.ticketQuantity,
                        TicketPrice = ticketDetail.ticketPrice
                    })
                    .ToList();

                // Thêm chi tiết đơn hàng vào ManageOrders
                if (_manageOrders.TableOrders.ContainsKey(selectedTable))
                {
                    _manageOrders.TableOrders[selectedTable].AddRange(orderDetails);
                }
                else
                {
                    _manageOrders.TableOrders[selectedTable] = orderDetails;
                }

                flowLayoutPanel1.Controls.Clear(); // Xóa các item sau khi đặt bàn
                lblSum.Text = "0 VND";
                LoadComboBox(); // Cập nhật lại ComboBox để loại bỏ bàn đã đặt
            }
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            lblSum.Text = "0 VND";
        }
    }
}
