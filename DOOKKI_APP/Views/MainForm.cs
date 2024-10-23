using DOOKKI_APP.Models.Entities;
using DOOKKI_APP.Views;

namespace DOOKKI_APP
{
    public partial class MainForm : Form
    {
        private readonly DookkiContext _context;
        public MainForm(DookkiContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
