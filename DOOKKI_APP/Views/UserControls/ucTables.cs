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
        private bool _isOccupied;
        public ucTables()
        {
            InitializeComponent();
            UpdateTableColor(); ;

            //Registrate event click
            btnTable.Click += (s, e) => OnClick(e);
        }

        //Update table empty or full
        public bool IsOccupied
        {
            get { return _isOccupied; }
            set
            {
                _isOccupied = value;
                UpdateTableColor();
            }
        }

        private void UpdateTableColor()
        {
            btnTable.BackColor = _isOccupied ? Color.Red : Color.Green;
        }

        public string TableName
        {
            get { return btnTable.Text; }
            set { btnTable.Text = value; }
        }
    }
}
