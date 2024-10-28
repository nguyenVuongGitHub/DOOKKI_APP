using DOOKKI_APP.Controllers;
using DOOKKI_APP.Models;
using DOOKKI_APP.Models.Entities;
using DOOKKI_APP.Views.UserControls;
using Microsoft.EntityFrameworkCore;
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
    public partial class TableForm : Form
    {
        private readonly ManageOrders _manageOrders;
        private readonly DookkiContext _context;

        public TableForm(DookkiContext context, ManageOrders manageOrders)
        {
            InitializeComponent();
            _manageOrders = manageOrders;
            _context = context;
            LoadTables();
            LoadComboBox();
        }
        //Display 29 tables in FlowLayoutPanel
        private void LoadTables()
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= 29; i++)
            {
                var tableName = "Bàn " + i;
                var table = new ucTables
                {
                    TableName = tableName,
                    IsOccupied = _manageOrders.TableStatus.ContainsKey(tableName) && _manageOrders.TableStatus[tableName]
                };

                flowLayoutPanel1.Controls.Add(table);
                table.Click += Table_Click;
            }
        }
        //Get a available table
        //public List<string> GetAvailableTables()
        //{
        //    List<string> tables = new List<string>();

        //    foreach (ucTables table in flowLayoutPanel1.Controls)
        //    {
        //        if (!table.IsOccupied)
        //        {
        //            tables.Add(table.TableName);
        //        }
        //    }
        //    return tables;
        //}
        //public void BookTableByName(string tableName)
        //{
        //    var table = flowLayoutPanel1.Controls
        //    .OfType<ucTables>()
        //    .FirstOrDefault(t => t.TableName == tableName);

        //    if (table != null)
        //    {
        //        table.IsOccupied = true;
        //        _tableStatus[tableName] = true; // Cập nhật trạng thái bàn
        //    }
        //}
        private void Table_Click(object sender, EventArgs e)
        {
            var table = sender as ucTables;
            if (table != null && table.IsOccupied && _manageOrders.TableOrders.ContainsKey(table.TableName))
            {
                tableLayoutPanel1.Controls.Clear();

                var orders = _manageOrders.TableOrders[table.TableName];

                var parentForm = this.FindForm() as TableForm; // Find the parent TableForm
                parentForm?.SetTableName(table.TableName);

                tableLayoutPanel1.RowCount = orders.Count;
                tableLayoutPanel1.ColumnCount = 3; // 3 column (TicketName, Quantity, Price)

                // Add Style of Row
                tableLayoutPanel1.RowStyles.Clear(); // Delete all RowStyle (if have)
                for (int i = 0; i < orders.Count; i++)
                {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize)); //AutoSize table
                }

                // Thêm các đơn hàng vào TableLayoutPanel
                for (int i = 0; i < orders.Count; i++)
                {
                    var order = orders[i];
                    tableLayoutPanel1.Controls.Add(new Label { Text = order.TicketName, Dock = DockStyle.Fill });
                    tableLayoutPanel1.Controls.Add(new Label { Text = order.Quantity.ToString(), Dock = DockStyle.Fill });
                    tableLayoutPanel1.Controls.Add(new Label { Text = order.TicketPrice.ToString("#,##0 VND"), Dock = DockStyle.Fill });
                }
                decimal totalSum = orders.Sum(order => order.TicketPrice * order.Quantity);
                parentForm?.SetTotalSum(totalSum);
                LoadComboBox();
            }

            else
            {
                // Create and open MenuForm with the selected table number
                var menuForm = new MenuForm(_context, table.TableName, this, _manageOrders);
                //menuForm.ShowDialog(); // Open as a modal dialog
                _manageOrders.openChildForm(menuForm);
                LoadComboBox();
            }
        }
        public void SetTableName(string tableName)
        {
            lblTable.Text = tableName;
        }
        public void SetTotalSum(decimal totalSum)
        {
            lblSum.Text = totalSum.ToString("#,##0 VND"); // Format the total sum
        }
        public void UpdateTableStatus(string tableName, bool isOccupied)
        {
            if (_manageOrders.TableStatus.ContainsKey(tableName))
            {
                _manageOrders.TableStatus[tableName] = isOccupied;
            }

            // Update the specific `ucTables` instance if required
            var table = flowLayoutPanel1.Controls
                .OfType<ucTables>()
                .FirstOrDefault(t => t.TableName == tableName);

            if (table != null)
            {
                table.IsOccupied = isOccupied;
                //table.BookTable(); // Assume this updates the UI for occupied status
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnTableChange_Click(object sender, EventArgs e)
        {
            var currentTableName = lblTable.Text; // Assuming lblSelectedTable displays the selected table
            var newTableName = cbEmptyTable.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newTableName))
            {
                MessageBox.Show("Hãy chọn bàn muốn chuyển");
                return;
            }

            // Perform table transfer
            TransferTable(currentTableName, newTableName);
        }

        private void LoadComboBox()
        {
            cbEmptyTable.Items.Clear();

            // Lấy danh sách các bàn có trạng thái trống (IsOccupied = false) từ TableStatus
            foreach (var table in _manageOrders.TableStatus.Where(t => !t.Value))
            {
                cbEmptyTable.Items.Add(table.Key);
            }
        }

        private void TransferTable(string fromTable, string toTable)
        {
            if (!_manageOrders.TableOrders.ContainsKey(fromTable)) return;

            // Get orders from the original table
            var ordersToTransfer = _manageOrders.TableOrders[fromTable];

            // Transfer orders to the new table
            if (_manageOrders.TableOrders.ContainsKey(toTable))
            {
                _manageOrders.TableOrders[toTable].AddRange(ordersToTransfer);
            }
            else
            {
                _manageOrders.TableOrders[toTable] = new List<OrderInfo>(ordersToTransfer);
            }

            // Clear the original table's orders and update statuses
            _manageOrders.TableOrders.Remove(fromTable);
            _manageOrders.TableStatus[fromTable] = false; // Mark the original table as free
            _manageOrders.TableStatus[toTable] = true; // Mark the new table as occupied

            // Refresh the UI
            UpdateTableStatus(fromTable, false); // Update the original table status to free
            UpdateTableStatus(toTable, true); // Update the new table status to occupied

            LoadComboBox(); // Refresh the ComboBox with available tables

            MessageBox.Show($"Bàn {fromTable} đã chuyển thành công đến bàn {toTable}.");
        }

    }
}
