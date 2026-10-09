using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace PhumlaKamnandiHotel_Project
{
    public partial class ReservationMenu : Form
    {
        public ReservationMenu()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            new MakeBooking().ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            new ChangeBooking().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new CancelBooking().ShowDialog();
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            new Enquiry().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Report().ShowDialog();
        }
    }
}
