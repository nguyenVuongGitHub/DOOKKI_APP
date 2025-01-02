//using DOOKKI_APP.Controllers;
//using DOOKKI_APP.Helpers;
//using DOOKKI_APP.Models;
//using DOOKKI_APP.Models.Entities;
//using DOOKKI_APP.Views.UserControls;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace DOOKKI_APP.Views
//{
//    public partial class TableForm : Form
//    {
//        private readonly MainForm _manageOrders;
//        private readonly DookkiContext _context;
//        private ucTables _selectedTable;

//        public TableForm(DookkiContext context, MainForm manageOrders)
//        {
//            InitializeComponent();
//            _manageOrders = manageOrders;
//            _context = context;
//            LoadTables();
//            LoadComboBox();
//        }
//        //Display 29 tables in FlowLayoutPanel
//        private void LoadTables()
//        {
//            flowLayoutPanel1.Controls.Clear();

//            for (int i = 1; i <= 29; i++)
//            {
//                var tableName = "Bàn " + i;
//                var table = new ucTables
//                {
//                    TableName = tableName,
//                    //Kiểm tra nếu bàn ở khóa tableName có tồn tại => true, và kiểm tra trạng thái của bạn có trống hay không (trống => false), (full => true))
//                    IsOccupied = _manageOrders.TableStatus.ContainsKey(tableName) && _manageOrders.TableStatus[tableName]
//                };

//                flowLayoutPanel1.Controls.Add(table);
//                table.ContextMenuStrip = contextMenuStrip1;
//                table.Click += Table_Click;
//                table.MouseUp += Table_MouseUp;
//            }
//        }
//        public void ClearTable()
//        {
//            tableLayoutPanel1.Controls.Clear();
//            lblTable.Text = "";
//            lblSum.Text = "";
//            LoadComboBox();
//        }
//        private void Table_Click(object sender, EventArgs e)
//        {
//            var table = sender as ucTables;
//            //Kiểm tra nếu bàn đã full thì thực hiện xuất order details
//            if (table != null && table.IsOccupied && _manageOrders.TableOrders.ContainsKey(table.TableName))
//            {
//                tableLayoutPanel1.Controls.Clear();

//                var orders = _manageOrders.TableOrders[table.TableName];

//                var parentForm = this.FindForm() as TableForm; // Find the parent TableForm
//                parentForm?.SetTableName(table.TableName);

//                tableLayoutPanel1.RowCount = orders.Count;
//                tableLayoutPanel1.ColumnCount = 3; // 3 column (TicketName, Quantity, Price)

//                // Add Style of Row
//                tableLayoutPanel1.RowStyles.Clear(); // Delete all RowStyle (if have)
//                for (int i = 0; i < orders.Count; i++)
//                {
//                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize)); //AutoSize table
//                }

//                // Thêm các đơn hàng vào TableLayoutPanel
//                for (int i = 0; i < orders.Count; i++)
//                {
//                    var order = orders[i];
//                    tableLayoutPanel1.Controls.Add(new Label { Text = order.TicketName, Dock = DockStyle.Fill });
//                    tableLayoutPanel1.Controls.Add(new Label { Text = order.Quantity.ToString(), Dock = DockStyle.Fill });
//                    tableLayoutPanel1.Controls.Add(new Label { Text = order.TicketPrice.ToString("#,##0 VND"), Dock = DockStyle.Fill });
//                }
//                decimal totalSum = orders.Sum(order => order.TicketPrice * order.Quantity);
//                parentForm?.SetTotalSum(totalSum);
//                LoadComboBox();
//                ShareData.TableName = lblTable.Text;
//            }

//            else
//            {
//                // Create and open MenuForm with the selected table number
//                var menuForm = new MenuForm(_context, table.TableName, this, _manageOrders);
//                _manageOrders.openChildForm(menuForm);
//                LoadComboBox();
//            }
//        }

//        private void Table_MouseUp(object sender, MouseEventArgs e)
//        {
//            if(e.Button == MouseButtons.Right)
//            {
//                var table = sender as ucTables;
//                if (table != null)
//                {
//                    // Optionally, perform any setup before showing the menu
//                    contextMenuStrip1.Show(table, e.Location); // Show menu at click location on the table
//                }
//            }
//        }
//        public void SetTableName(string tableName)
//        {
//            lblTable.Text = tableName;
//        }
//        public void SetTotalSum(decimal totalSum)
//        {
//            lblSum.Text = totalSum.ToString("#,##0 VND"); // Format the total sum
//        }
//        public void UpdateTableStatus(string tableName, bool isOccupied)
//        {
//            if (_manageOrders.TableStatus.ContainsKey(tableName))
//            {
//                _manageOrders.TableStatus[tableName] = isOccupied;
//            }

//            // Update the specific `ucTables` instance if required
//            var table = flowLayoutPanel1.Controls
//                .OfType<ucTables>()
//                .FirstOrDefault(t => t.TableName == tableName);

//            if (table != null)
//            {
//                table.IsOccupied = isOccupied;
//            }
//        }

//        private void btnPay_Click(object sender, EventArgs e)
//        {
//            // had already click at table
//            if(lblTable.Text != "") 
//            {
//                List<OrderInfo> orderInfors = _manageOrders.TableOrders[lblTable.Text];

//                List<OrderDetail> orderDetails = new List<OrderDetail>();
//                foreach (var order in orderInfors)
//                {
//                    OrderDetail orderDetail = new OrderDetail();
//                    orderDetail.Quantily = order.Quantity;
//                    int ticketID = (from ti in _context.Tickets
//                                    where ti.Name == order.TicketName
//                                    select ti.Id).SingleOrDefault();
//                    orderDetail.TicketId = ticketID;

//                    orderDetails.Add(orderDetail);
//                }
//                //open form payment
//                //Form paymentForm = new PaymentForm(new Order(), new Payment(), orderDetails, _context, _manageOrders, this);
//                //paymentForm.Show();
//            }
//        }

//        private void btnTableChange_Click(object sender, EventArgs e)
//        {
//            var currentTableName = lblTable.Text; // Assuming lblSelectedTable displays the selected table
//            var newTableName = cbEmptyTable.SelectedItem?.ToString();

//            if (string.IsNullOrEmpty(newTableName))
//            {
//                MessageBox.Show("Hãy chọn bàn muốn chuyển");
//                return;
//            }

//            // Perform table transfer
//            TransferTable(currentTableName, newTableName);
//        }

//        public void LoadComboBox()
//        {
//            cbEmptyTable.Items.Clear();

//            // Lấy danh sách các bàn có trạng thái trống (IsOccupied = false) từ TableStatus
//            foreach (var table in _manageOrders.TableStatus.Where(t => !t.Value))
//            {
//                cbEmptyTable.Items.Add(table.Key);
//            }
//        }

//        private void TransferTable(string fromTable, string toTable)
//        {
//            if (!_manageOrders.TableOrders.ContainsKey(fromTable)) return;

//            // Get orders from the original table
//            var ordersToTransfer = _manageOrders.TableOrders[fromTable];

//            // Transfer orders to the new table
//            if (_manageOrders.TableOrders.ContainsKey(toTable))
//            {
//                _manageOrders.TableOrders[toTable].AddRange(ordersToTransfer);
//            }
//            else
//            {
//                _manageOrders.TableOrders[toTable] = new List<OrderInfo>(ordersToTransfer);
//            }

//            // Clear the original table's orders and update statuses
//            _manageOrders.TableOrders.Remove(fromTable);
//            _manageOrders.TableStatus[fromTable] = false; // Mark the original table as free
//            _manageOrders.TableStatus[toTable] = true; // Mark the new table as occupied

//            // Refresh the UI
//            UpdateTableStatus(fromTable, false); // Update the original table status to free
//            UpdateTableStatus(toTable, true); // Update the new table status to occupied

//            LoadComboBox(); // Refresh the ComboBox with available tables

//            MessageBox.Show($"Bàn {fromTable} đã chuyển thành công đến bàn {toTable}.");
//        }

//        private void btnUpdate_Click(object sender, EventArgs e)
//        {
            
//        }

//        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            var selectedTableName = lblTable.Text;

//            // Check if the table has an existing order to update
//            if (_manageOrders.TableOrders.ContainsKey(selectedTableName))
//            {
//                // Open MenuForm with the selected table to update tickets
//                var menuForm = new MenuForm(_context, selectedTableName, this, _manageOrders, isUpdateMode: true);
//                _manageOrders.openChildForm(menuForm);
//                LoadComboBox();
//            }
//            else
//            {
//                MessageBox.Show("No order exists for this table. Please place a new order first.");
//            }
//        }

//        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            // Lấy bàn hiện tại từ contextMenuStrip
//            var table = contextMenuStrip1.SourceControl as ucTables;
//            if (table != null)
//            {
//                // Xóa hết vé của bàn đó
//                if (_manageOrders.TableOrders.ContainsKey(table.TableName))
//                {
//                    _manageOrders.TableOrders[table.TableName].Clear();
//                    lblTable.Text = "";
//                    tableLayoutPanel1.Controls.Clear();
//                    lblSum.Text = "0 VND";
//                    LoadComboBox();
//                }

//                // Cập nhật trạng thái bàn thành trống
//                _manageOrders.TableStatus[table.TableName] = false;
//                table.IsOccupied = false;

//                // Cập nhật hiển thị bàn để trông như ban đầu
//                table.Refresh(); // Gọi refresh để cập nhật lại trạng thái hiển thị của bàn nếu cần
//                MessageBox.Show($"Đã xóa hết vé của {table.TableName} và đặt lại trạng thái bàn.", "Xóa thành công");
//            }
//        }
//    }
//}
