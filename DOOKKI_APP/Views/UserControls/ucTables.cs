using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOOKKI_APP.Views.UserControls
{
    public partial class ucTables : UserControl
    {
        public bool IsOccupied = false;
        public ucTables()
        {
            InitializeComponent();
            btnTable.BackColor = Color.Green;
        }

        public string TableName
        {
            get { return btnTable.Text; }
            set { btnTable.Text = value; }
        }
        public void BookTable()
        {
            btnTable.BackColor = Color.Red;
            IsOccupied = true;
        }
    }
}
