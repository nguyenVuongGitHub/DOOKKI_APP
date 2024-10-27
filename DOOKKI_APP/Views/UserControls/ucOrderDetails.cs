using DOOKKI_APP.Models;
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
    public partial class ucOrderDetails : UserControl
    {
        public ucOrderDetails()
        {
            InitializeComponent();
        }
        public void DisplayOrderDetails(List<OrderInfo> orders)
        {
            tableLayoutPanel1.Controls.Clear();

            foreach (var order in orders)
            {
                tableLayoutPanel1.Controls.Add(new Label { Text = order.TicketName });
                tableLayoutPanel1.Controls.Add(new Label { Text = order.Quantity.ToString() });
                tableLayoutPanel1.Controls.Add(new Label { Text = order.TicketPrice.ToString("#,##0 VND") });
            }
        }
    }
}
