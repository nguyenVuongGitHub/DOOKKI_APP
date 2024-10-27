using DOOKKI_APP.Helpers;
using DOOKKI_APP.Models.Entities;
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
    public partial class TestForm : Form
    {
        DookkiContext _context;
        public TestForm(DookkiContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExportFile export = new ExportFile(_context);
                var newOrder = _context.Orders.ToList().ElementAt(2);
                if (newOrder != null)
                {
                    bool exported = export.ExportToPDF(newOrder);
                    if (exported)
                        MessageBox.Show("Xuat file thanh cong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Day ne: " + ex.Message);
            }
        }
    }
}
