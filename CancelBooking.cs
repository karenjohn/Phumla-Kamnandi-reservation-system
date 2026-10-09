using PhumlaKamnandiHotel_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PhumlaKamnandiHotel_Project
{
    public partial class CancelBooking : Form
    {
        public CancelBooking()
        {
            InitializeComponent();
        }

        private DataRow GetReservationByResID(string resId)
        {//allows cancellation of a booking using reservation ID, by analyzing the information stored in tables.
            string sql = @"
        SELECT 
            r.ResID,
            g.FullName,
            g.Contact,
            r.CheckInDate,
            r.CheckOutDate,
            r.Status,
            r.NumGuests,
            r.DepositAmount,
            rm.RoomType
        FROM Reservation r
        INNER JOIN Guest g ON r.GuestID = g.GuestID
        INNER JOIN Room rm ON r.RoomID = rm.RoomID
        WHERE r.ResID = @ResID;";

            SqlParameter param = new SqlParameter("@ResID", resId);
            DataTable dt = DatabaseHelper.ExecuteQuery(sql, param);

            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            else
                return null;
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            string resId = txtRef.Text.Trim();

            if (string.IsNullOrEmpty(resId))
            {
                MessageBox.Show("Please enter the Reservation ID.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Look up the reservation by ResID
            DataRow reservation = GetReservationByResID(resId);

            if (reservation == null)
            {
                MessageBox.Show($"No reservation found with ID {resId}.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string status = reservation["Status"].ToString();

            // Build guest and reservation summary to show in a popup
            string guestDetails =
                $"Reservation ID: {reservation["ResID"]}\n" +
                $"Guest Name: {reservation["FullName"]}\n" +
                $"Contact: {reservation["Contact"]}\n" +
                $"Room Type: {reservation["RoomType"]}\n" +
                $"No. of Guests: {reservation["NumGuests"]}\n" +
                $"Check-In Date: {Convert.ToDateTime(reservation["CheckInDate"]).ToShortDateString()}\n" +
                $"Check-Out Date: {Convert.ToDateTime(reservation["CheckOutDate"]).ToShortDateString()}\n" +
                $"Deposit Amount: R{Convert.ToDecimal(reservation["DepositAmount"]).ToString("0.00")}\n" +
                $"Status: {status}";

            if (status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    $"Reservation {resId} is already CANCELLED.\n\n{guestDetails}",
                    "Already Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Show details before confirming cancellation
            DialogResult confirm = MessageBox.Show(
                $"Please review the details below before cancelling:\n\n{guestDetails}\n\n" +
                "Do you want to proceed with cancellation?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


            if (confirm == DialogResult.Yes)
            {
                // Update the reservation to 'Cancelled'
                string cancelQuery = @"UPDATE Reservation
                                       SET Status = 'Cancelled'
                                       WHERE ResID = @ResID;";

                SqlParameter param = new SqlParameter("@ResID", resId);
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(cancelQuery, param);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Reservation {resId} for {reservation["FullName"]} has been successfully CANCELLED. \n\n{guestDetails}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRef.Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to cancel reservation {resId}. Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}