using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiHotel_Project
{
    public partial class InvoiceSummaryForm : Form
    {

        public string GuestName { get; set; }
        public decimal RoomRate { get; set; }
        public int Nights { get; set; }
        public decimal Total { get; set; }
        public decimal Deposit { get; set; }
        public decimal Balance { get; set; }
        public int InvoiceID { get; set; }
        public InvoiceSummaryForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing not yet implemented — coming soon!",
            "Print Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InvoiceSummaryForm_Load(object sender, EventArgs e)
        {
            lblGuestName.Text = $"Guest: {GuestName}";
            lblInvoiceId.Text = $"Invoice #: {InvoiceID}";
            lblRate.Text = $"Room rate: R{RoomRate:0.00}";
            lblNights.Text = $"Nights: {Nights}";
            lblTotal.Text = $"Total: R{Total:0.00}";
            lblDeposit.Text = $"Deposit: R{Deposit:0.00}";
            lblBalance.Text = $"Balance due: R{Balance:0.00}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
