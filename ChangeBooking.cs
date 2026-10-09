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
    public partial class ChangeBooking : Form
    {
        private string currentResID;
        public ChangeBooking()
        {
            InitializeComponent();
            LoadRoomTypes();
        }

        // Load available room types from Room table
        private void LoadRoomTypes()
        {
            string sql = "SELECT RoomID, RoomType, Rate FROM Room;";
            DataTable rooms = DatabaseHelper.ExecuteQuery(sql);

            cmbRoomType.DisplayMember = "RoomType";
            cmbRoomType.ValueMember = "RoomID";
            cmbRoomType.DataSource = rooms;
        }

        // Get one Reservation by its ID
        private DataRow GetReservationByResID(string resId)
        {
            string sql = @"
                SELECT r.ResID, g.FullName, r.RoomID, r.CheckInDate, r.CheckOutDate, 
                       r.NumGuests, r.DepositAmount, rm.Rate, r.Status
                FROM Reservation r
                INNER JOIN Guest g ON r.GuestID = g.GuestID
                INNER JOIN Room rm ON r.RoomID = rm.RoomID
                WHERE r.ResID = @ResID";

            SqlParameter param = new SqlParameter("@ResID", resId);
            DataTable dt = DatabaseHelper.ExecuteQuery(sql, param);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // When Load button is clicked
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string resId = txtResID.Text.Trim();

            if (string.IsNullOrEmpty(resId))
            {
                MessageBox.Show("Please enter a Reservation ID.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow reservation = GetReservationByResID(resId);

            if (reservation == null)
            {
                MessageBox.Show($"No reservation found with ID {resId}.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 🟠 Check if reservation was cancelled
            string status = reservation["Status"]?.ToString();
            if (status != null && status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                // Treat as not found
                MessageBox.Show($"Reservation {resId} not found.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear any previous data in the form
                ClearFormFields();

                return;
            }

            currentResID = resId;

            // Populate form fields
            txtGuestName.Text = reservation["FullName"].ToString();
            numGuestsUpDown.Value = Convert.ToInt32(reservation["NumGuests"]);
            cmbRoomType.SelectedValue = reservation["RoomID"].ToString();
            dtCheckIn.Value = Convert.ToDateTime(reservation["CheckInDate"]);
            dtCheckOut.Value = Convert.ToDateTime(reservation["CheckOutDate"]);
            txtRate.Text = Convert.ToDecimal(reservation["Rate"]).ToString("0.00");
            txtDeposit.Text = Convert.ToDecimal(reservation["DepositAmount"]).ToString("0.00");

            MessageBox.Show($"Reservation {resId} loaded successfully.",
                "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearFormFields()
        {
            txtGuestName.Clear();
            numGuestsUpDown.Value = 1;
            cmbRoomType.SelectedIndex = -1;
            txtRate.Clear();
            txtDeposit.Clear();
            dtCheckIn.Value = DateTime.Now;
            dtCheckOut.Value = DateTime.Now.AddDays(1);
        }

        // When room type changes — auto update Rate & Deposit
        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRoomType.SelectedItem is DataRowView selectedRoom)
                {
                    decimal rate = Convert.ToDecimal(selectedRoom["Rate"]);
                    txtRate.Text = rate.ToString("0.00");

                    // Example: Deposit = 50% of rate × number of nights
                    int nights = (dtCheckOut.Value.Date - dtCheckIn.Value.Date).Days;
                    if (nights < 1) nights = 1; // minimum 1 night
                    decimal deposit = rate * 0.5m * nights;
                    txtDeposit.Text = deposit.ToString("0.00");
                }
            }
            catch
            {
                // Ignore index change during form initialization
            }
        }

        // Save updated booking info
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentResID))
            {
                MessageBox.Show("Please load a reservation first.",
                    "No Reservation Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"
                UPDATE Reservation
                SET RoomID = @RoomID,
                    CheckInDate = @CheckInDate,
                    CheckOutDate = @CheckOutDate,
                    NumGuests = @NumGuests,
                    DepositAmount = @DepositAmount
                WHERE ResID = @ResID";

            SqlParameter[] parameters = {
                new SqlParameter("@RoomID", cmbRoomType.SelectedValue),
                new SqlParameter("@CheckInDate", dtCheckIn.Value),
                new SqlParameter("@CheckOutDate", dtCheckOut.Value),
                new SqlParameter("@NumGuests", numGuestsUpDown.Value),
                new SqlParameter("@DepositAmount", Convert.ToDecimal(txtDeposit.Text)),
                new SqlParameter("@ResID", currentResID)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(sql, parameters);

            if (rows > 0)
            {
                MessageBox.Show($"Reservation {currentResID} updated successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update reservation. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Optional: auto update deposit when dates are changed
        private void dateCheckIn_ValueChanged(object sender, EventArgs e)
        {
            UpdateDeposit();
        }

        private void dateCheckOut_ValueChanged(object sender, EventArgs e)
        {
            UpdateDeposit();
        }

        // Helper to recalculate deposit automatically
        private void UpdateDeposit()
        {
            if (cmbRoomType.SelectedItem is DataRowView selectedRoom)
            {
                decimal rate = Convert.ToDecimal(selectedRoom["Rate"]);
                int nights = (dtCheckOut.Value.Date - dtCheckIn.Value.Date).Days;
                if (nights < 1) nights = 1;
                decimal deposit = rate * 0.5m * nights;
                txtDeposit.Text = deposit.ToString("0.00");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
