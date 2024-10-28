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
        public decimal ticketPrice { get; set; }
        private int _ticketQuantity;
        public ucTicketDetail()
        {
            InitializeComponent();
        }
        public int ticketQuantity
        {
            get => _ticketQuantity;
            set
            {
                _ticketQuantity = value;
                lblQuantity.Text = _ticketQuantity.ToString();
                lblPrice.Text = (ticketPrice * _ticketQuantity).ToString("#,##0 VND"); // Update price label
            }
        }
        public string ticketName
        {
            get { return lblTicketName.Text; }
            set { lblTicketName.Text = value; }
        }
    }
}