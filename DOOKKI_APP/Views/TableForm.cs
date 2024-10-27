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

namespace DOOKKI_APP.Views
{
    public partial class TableForm : Form
    {
        private ManageOrders _manageOrders;

        public TableForm(ManageOrders manageOrders)
        {
            InitializeComponent();
            _manageOrders = manageOrders;
            LoadTables();
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
                var orders = _manageOrders.TableOrders[table.TableName];

                var parentForm = this.FindForm() as TableForm; // Find the parent TableForm
                parentForm?.SetTableName(table.TableName);

                tableLayoutPanel1.RowCount = orders.Count;
                tableLayoutPanel1.ColumnCount = 3; // Số cột là 3 (TicketName, Quantity, Price)

                // Thêm kiểu cho các hàng
                tableLayoutPanel1.RowStyles.Clear(); // Xóa tất cả RowStyles nếu cần
                for (int i = 0; i < orders.Count; i++)
                {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Thiết lập kiểu hàng tự động điều chỉnh
                }

                // Thêm các đơn hàng vào TableLayoutPanel
                for (int i = 0; i < orders.Count; i++)
                {
                    var order = orders[i];
                    tableLayoutPanel1.Controls.Add(new Label { Text = order.TicketName, Dock = DockStyle.Fill });
                    tableLayoutPanel1.Controls.Add(new Label { Text = order.Quantity.ToString(), Dock = DockStyle.Fill });
                    tableLayoutPanel1.Controls.Add(new Label { Text = order.TicketPrice.ToString("#,##0 VND"), Dock = DockStyle.Fill });
                }
            }
        }
        public void SetTableName(string tableName)
        {
            lblTable.Text = tableName;
        }
    }
}
