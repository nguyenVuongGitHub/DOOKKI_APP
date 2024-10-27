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
        public TableForm()
        {
            InitializeComponent();
            LoadTables();
        }
        //Display 29 tables in FlowLayoutPanel
        private void LoadTables()
        {
            for (int i = 1; i <= 29; i++)
            {
                ucTables tables = new ucTables();
                tables.TableName = "Bàn " + i;

                flowLayoutPanel1.Controls.Add(tables);
            }
        }
        //Get a available table
        public List<string> GetAvailableTables()
        {
            List<string> tables = new List<string>();

            foreach(ucTables table in flowLayoutPanel1.Controls)
            {
                if(!table.IsOccupied)
                {
                    tables.Add(table.TableName);
                }
            }
            return tables;
        }
        public void BookTableByName(string tableName)
        {
            foreach (ucTables table in flowLayoutPanel1.Controls)
            {
                if (table.TableName == tableName && !table.IsOccupied)
                {
                    table.BookTable();
                    break;
                }
            }
        }
         
    }
}
