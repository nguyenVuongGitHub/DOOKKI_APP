using DOOKKI_APP.Models.Entities;
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

namespace DOOKKI_APP.Views.UserControls
{
    public partial class ucTicketDetail : UserControl
    {
        //private readonly DookkiContext _context;
        //public ucOderDetails(DookkiContext context)
        //{
        //    _context = context;
        //    InitializeComponent();
        //}
        //public void loadOrderDetails()
        //{
        //    //Delete data available
        //    tableLayoutPanel1.RowStyles.Clear();
        //    tableLayoutPanel1.Controls.Clear();

        //    //Get data
        //    var orderDetails = _context.OrderDetails
        //        .Include(od => od.Ticket)
        //        .Include(od => od.Payment)
        //        .Select(od => new
        //        {
        //            nameTicket = od.Ticket.TicketName,
        //            quantity = od.Quantily,
        //            priceSum = od.Payment.Amount
        //        }).ToList();

        //    //Load data into tableLayoutPanel
        //    int row = 1;
        //    foreach (var detail in orderDetails)
        //    {
        //        Label lblName = new Label { Text = detail.nameTicket, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
        //        tableLayoutPanel1.Controls.Add(lblName, 0, row);

        //        Label lblQuantity = new Label { Text = detail.quantity.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
        //        tableLayoutPanel1.Controls.Add(lblQuantity, 1, row);

        //        Label lblPriceSum = new Label { Text = detail.priceSum.ToString(" VND"), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
        //        tableLayoutPanel1.Controls.Add(lblPriceSum, 2, row);

        //        row++;

        //        //Update row
        //        tableLayoutPanel1.RowCount = row;
        //    }
        //}

        //private void ucOderDetails_Load(object sender, EventArgs e)
        //{
        //    loadOrderDetails();
        //}

        public ucTicketDetail()
        {
            InitializeComponent();
        }

        public string ticketName
        {
            get { return lblTicketName.Text; }
            set { lblTicketName.Text = value; }
        }
        public int ticketQuantity
        {
            get { return int.Parse(lblQuantity.Text); }
            set { lblQuantity.Text = value.ToString(); }
        }
        public decimal ticketPrice
        {
            get { return decimal.Parse(lblPrice.Text); }
            set { lblPrice.Text = value.ToString(); }
        }
    }
}