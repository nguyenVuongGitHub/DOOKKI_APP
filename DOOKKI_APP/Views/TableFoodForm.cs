using DOOKKI_APP.Controllers;
using DOOKKI_APP.Models;
using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOOKKI_APP.Views
{
    public partial class TableFoodForm : Form
    {
        DookkiContext _context;
        public TableFoodForm(DookkiContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void TableFoodForm_Load(object sender, EventArgs e)
        {
            LoadTables();
            LoadCategory();
            LoadEmptyTable();
        }

        void LoadCategory()
        {
            var categoryTicket = CategoryTicketControllerSingleton.Instance.GetListCategoryTicket();
            cbCategory.DataSource = categoryTicket;
            cbCategory.DisplayMember = "Name";
        }

        void LoadProductListByCategoryTicketID(int id)
        {
            var ticketList = TicketControllerSingleton.Instance.GetTicketByCategoryTicketID(id);
            cbTicket.DataSource = ticketList;
            cbTicket.DisplayMember = "Name";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox; // Ép kiểu sender thành ComboBox
            if (cb.SelectedItem == null) return;

            CategoryTicket selected = cb.SelectedItem as CategoryTicket; // Lấy item đang chọn và ép kiểu về Category
            id = selected.Id; // Lấy ID từ đối tượng Category

            LoadProductListByCategoryTicketID(id);
        }

        void LoadEmptyTable()
        {
            cbEmptyTable.DataSource = TableFoodControllerSingleton.Instance.GetTableList();
            cbEmptyTable.DisplayMember = "Name";
        }

        private void LoadTables()
        {
            flowLayoutPanel1.Controls.Clear();
            // Lấy danh sách bàn từ Controller
            var tables = TableFoodControllerSingleton.Instance.GetTableList();

            foreach (var table in tables)
            {
                // Tạo một Panel đại diện cho mỗi bàn
                Panel panel = new Panel
                {
                    Width = 128,
                    Height = 100,
                    BackColor = table.Status == false ? Color.Cyan : Color.Pink
                };

                // Thêm nhãn hiển thị tên bàn
                Button btnName = new Button
                {
                    Text = table.Name,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Cursor = Cursors.Hand
                };
                panel.Controls.Add(btnName);

                // Thêm sự kiện click cho panel (nếu cần)
                btnName.Click += btn_Click;
                btnName.Tag = table;

                // Thêm panel vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Table selectedTable = (sender as Button).Tag as Table;
            int tableID = selectedTable.Id;
            lsvOrder.Tag = selectedTable;
            lblTable.Text = $"{selectedTable.Name}";
            ShowOrder(tableID);
        }

        void ShowOrder(int id)
        {
            var menuItems = OrderControllerSingleton.Instance.GetMenuItem(id);
            decimal totalPrice = 0;
            lsvOrder.Items.Clear();

            foreach (var item in menuItems)
            {   
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());
                totalPrice += item.Total;
                lsvOrder.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTotalPrice.Text = totalPrice.ToString("c");
            nmProductQuantity.Value = 1;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Lay table
            Table table = lsvOrder.Tag as Table;
            //Lay id cua order dua vao id cua table
            int orderID = OrderControllerSingleton.Instance.GetUncheckOrderByTableID(table.Id);
            int ticketID = (cbTicket.SelectedItem as Ticket).Id;
            int quantity = (int)nmProductQuantity.Value;

            if (orderID == -1) // Order chua ton tai
            {
                OrderControllerSingleton.Instance.InsertOrder(table.Id);
                OrderControllerSingleton.Instance.InsertOrderDetail(OrderControllerSingleton.Instance.GetMaxOrderID(), ticketID, quantity);
            }
            else //Order da ton tai
            {
                OrderControllerSingleton.Instance.InsertOrderDetail(orderID, ticketID, quantity);
            }

            ShowOrder(table.Id);
            LoadTables();
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            Table table = lsvOrder.Tag as Table;

            int orderID = OrderControllerSingleton.Instance.GetUncheckOrderByTableID(table.Id);
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split('.')[0]);
            DialogResult result = MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.Name, "Thông báo", MessageBoxButtons.OKCancel);

            if (orderID != -1)
            {
                if (result == DialogResult.OK)
                {
                    List<OrderDetail> orderDetails = OrderControllerSingleton.Instance.GetOrderDetails(table.Id);
                    //open form payment
                    Form paymentForm = new PaymentForm(new Order(), new Payment(), orderDetails, _context, table.Id);
                    paymentForm.Show();

                }
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvOrder.Tag as Table).Id;
            int id2 = (cbEmptyTable.SelectedItem as Table).Id;
            DialogResult result = MessageBox.Show(String.Format("Bạn có chắc muốn chuyển bàn {0} qua bàn {1} không ?", (lsvOrder.Tag as Table).Name, (cbEmptyTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                TableFoodControllerSingleton.Instance.SwitchTable(id1, id2);
                LoadTables();
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Xóa")
            {
                if (lsvOrder.SelectedItems.Count > 0)
                {
                    var selectedItem = lsvOrder.SelectedItems[0];
                    string itemName = selectedItem.Text;
                    Table table = lsvOrder.Tag as Table;

                    // Gọi phương thức xóa món trong database
                    int orderId = OrderControllerSingleton.Instance.GetCurrentOrderId(table.Id); // Hàm lấy Order ID hiện tại
                    int ticketId = TicketControllerSingleton.Instance.GetTicketIdByName(itemName); // Hàm lấy Ticket ID từ tên món
                    OrderControllerSingleton.Instance.DeleteOrderDetail(orderId, ticketId);

                    // Cập nhật lại ListView
                    ShowOrder(table.Id); // Hàm lấy Table ID hiện tại
                    LoadTables();
                }
            }
        }
    }
}
