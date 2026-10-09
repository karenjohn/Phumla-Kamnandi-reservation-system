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
    public partial class MakeBooking : Form
    {
        public MakeBooking()
        {
            InitializeComponent();
            dtCheckIn.Value = DateTime.Today;  
            dtCheckOut.Value = DateTime.Today.AddDays(1);  
            ToggleBookingFields(false);
        }

        private void ToggleBookingFields(bool visible)
        {
            btnConfirm.Visible = visible;
            btnCancel.Visible = visible;
            btnClose.Visible = visible;
        }
        
        private bool IsValidContactNumber(string contact) // Validate contact number
        {
            return System.Text.RegularExpressions.Regex.IsMatch(contact, @"^0\d{9}$");
        }
        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomType.SelectedIndex < 0) return;

            try
            {
                string selectedType = cmbRoomType.Text.Trim();  // safer than SelectedValue for pre-filled items

                // Query to get the rate for this type
                string rateQuery = "SELECT AVG(Rate) AS Rate FROM Room WHERE RoomType = @RoomType";
                SqlParameter param = new SqlParameter("@RoomType", selectedType);

                DataTable dt = DatabaseHelper.ExecuteQuery(rateQuery, param);

                if (dt.Rows.Count > 0 && dt.Rows[0]["Rate"] != DBNull.Value)
                {
                    decimal rate = Convert.ToDecimal(dt.Rows[0]["Rate"]);
                    decimal deposit = rate * 0.10m;  // 10% deposit

                    txtRate.Text = rate.ToString("0.00");
                    txtDeposit.Text = deposit.ToString("0.00");
                }
                else
                {
                    txtRate.Clear();
                    txtDeposit.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving rate: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CreateInvoiceForReservation(int resID)
        {
            try
            {
                string sql = @"
            SELECT 
                r.ResID,
                g.FullName AS GuestName,
                r.CheckInDate,
                r.CheckOutDate,
                r.DepositAmount AS StoredDeposit,
                rm.Rate AS RoomRate
            FROM Reservation r
            INNER JOIN Guest g ON r.GuestID = g.GuestID
            INNER JOIN Room rm ON r.RoomID = rm.RoomID
            WHERE r.ResID = @ResID;";

                DataTable dt = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@ResID", resID));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Reservation not found.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }

                DataRow row = dt.Rows[0];
                string guestName = row["GuestName"].ToString();
                DateTime checkIn = Convert.ToDateTime(row["CheckInDate"]);
                DateTime checkOut = Convert.ToDateTime(row["CheckOutDate"]);
                decimal deposit = Convert.ToDecimal(row["StoredDeposit"]);
                decimal rate = Convert.ToDecimal(row["RoomRate"]);
                int nights = (checkOut - checkIn).Days;
                if (nights < 1) nights = 1;

                // Basic invoice math
                decimal total = rate * nights;
                decimal balance = total - deposit;

                // Insert invoice record
                string insert = @"
            INSERT INTO Account (ResID, TotalAmount, Status)
            VALUES (@ResID, @TotalAmount, 'Unpaid');
            SELECT SCOPE_IDENTITY();";

                DataTable dtNew = DatabaseHelper.ExecuteQuery(insert,
                    new SqlParameter("@ResID", resID),
                    new SqlParameter("@TotalAmount", total));

                int newInvoiceId = Convert.ToInt32(dtNew.Rows[0][0]);

                // Show invoice in your professional summary form
                InvoiceSummaryForm summaryForm = new InvoiceSummaryForm
                {
                    InvoiceID = newInvoiceId,
                    GuestName = guestName,
                    RoomRate = rate,
                    Nights = nights,
                    Total = total,
                    Deposit = deposit,
                    Balance = balance
                };

                summaryForm.ShowDialog();

                return newInvoiceId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating invoice: " + ex.Message,
                    "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Confirm button — validate and save booking
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtGuestName.Text) || string.IsNullOrWhiteSpace(txtContact.Text) ||  cmbRoomType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all required fields.",
                        "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsValidContactNumber(txtContact.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid 10-digit contact number.",
                        "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string guestName = txtGuestName.Text.Trim();
                string contact = txtContact.Text.Trim();
                string roomType = cmbRoomType.SelectedItem.ToString();
                int numGuests = Convert.ToInt32(numGuestsUpDown.Value);
                DateTime checkIn = dtCheckIn.Value.Date;
                DateTime checkOut = dtCheckOut.Value.Date;

                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check‑out date must be after check‑in date.",
                        "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //  FIND OR ADD GUEST 
                string getGuestQuery = "SELECT GuestID FROM Guest WHERE FullName = @FullName";
                DataTable existingGuest = DatabaseHelper.ExecuteQuery(getGuestQuery,
                    new SqlParameter("@FullName", guestName));

                int guestID;
                if (existingGuest.Rows.Count > 0)
                {
                    guestID = Convert.ToInt32(existingGuest.Rows[0]["GuestID"]);
                }
                else
                {
                    string insertGuest = "INSERT INTO Guest (FullName, Contact) VALUES (@FullName, @Contact); SELECT SCOPE_IDENTITY();";
                    DataTable newGuest = DatabaseHelper.ExecuteQuery(insertGuest,
                        new SqlParameter("@FullName", guestName),
                        new SqlParameter("@Contact", contact));
                    guestID = Convert.ToInt32(newGuest.Rows[0][0]);
                }

                //  FIND AVAILABLE ROOM 
                string findRoom = @"
                    SELECT TOP 1 RoomID FROM Room
                    WHERE RoomType = @RoomType 
                      AND AvailabilityStatus = 'Available'
                      AND RoomID NOT IN (
                          SELECT RoomID FROM Reservation
                          WHERE Status = 'Confirmed'
                          AND (@CheckIn < CheckOutDate AND @CheckOut > CheckInDate)
                      );";

                DataTable availableRoom = DatabaseHelper.ExecuteQuery(findRoom,
                    new SqlParameter("@RoomType", roomType),
                    new SqlParameter("@CheckIn", checkIn),
                    new SqlParameter("@CheckOut", checkOut));
                              

                if (availableRoom.Rows.Count == 0)
                {
                    MessageBox.Show("No available rooms of this type for selected dates.",
                        "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int roomID = Convert.ToInt32(availableRoom.Rows[0]["RoomID"]);
                decimal deposit = Convert.ToDecimal(txtDeposit.Text);

                // INSERT RESERVATION 
                string insertRes = @"
                    INSERT INTO Reservation (GuestID, RoomID, CheckInDate, CheckOutDate, NumGuests, Status, DepositAmount)
                    VALUES (@GuestID, @RoomID, @CheckIn, @CheckOut, @Guests, 'Confirmed', @Deposit);
                    SELECT SCOPE_IDENTITY();";

                DataTable result = DatabaseHelper.ExecuteQuery(insertRes,
                    new SqlParameter("@GuestID", guestID),
                    new SqlParameter("@RoomID", roomID),
                    new SqlParameter("@CheckIn", checkIn),
                    new SqlParameter("@CheckOut", checkOut),
                    new SqlParameter("@Guests", numGuests),
                    new SqlParameter("@Deposit", deposit));

                int reservationID = Convert.ToInt32(result.Rows[0][0]);

                // SUCCESS MESSAGE upon sucess in reservation
                MessageBox.Show($"Booking successful!\nReservation Reference: {reservationID}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int invoiceId = CreateInvoiceForReservation(reservationID);

                // Add Loyalty Points after successful booking
                int nights = (checkOut - checkIn).Days;
                if (nights < 1) nights = 1;
                int pointsEarned = 5 * nights;  // Example rule: 5 points per night

                UpdateLoyaltyPoints(guestID, pointsEarned);

                // Clear fields
                txtGuestName.Clear();
                txtContact.Clear();
                numGuestsUpDown.Value = 1;
                txtRate.Clear();
                txtDeposit.Clear();
                cmbRoomType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating booking: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Add Loyalty Points
        private void UpdateLoyaltyPoints(int guestId, int pointsEarned)
        {
            try
            {
                string sql = @"UPDATE Guest
                               SET LoyaltyPoints = ISNULL(LoyaltyPoints, 0) + @PointsEarned
                               WHERE GuestID = @GuestID;";

                SqlParameter[] parameters = {
                    new SqlParameter("@PointsEarned", pointsEarned),
                    new SqlParameter("@GuestID", guestId)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(sql, parameters);

                if (rows > 0)
                {
                    MessageBox.Show($"Guest {guestId} earned {pointsEarned} loyalty points!",
                        "Loyalty Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating loyalty points: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel button closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reset all fields
            txtGuestName.Clear();
            txtContact.Clear();
            numGuestsUpDown.Value = 1;  // Default 1 guest
            cmbRoomType.SelectedIndex = -1;  // Clear selection
            txtRate.Clear();
            txtDeposit.Clear();

            // Reset dates to today/tomorrow
            dtCheckIn.Value = DateTime.Today;  // October 12, 2025
            dtCheckOut.Value = DateTime.Today.AddDays(1);  // October 13, 2025

            // Optional: Hide booking fields if using ToggleBookingFields
            ToggleBookingFields(false);

            // Focus back to name for quick retry
            txtGuestName.Focus();

            MessageBox.Show("Fields reset—start a new booking.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DataRow GetGuestByNameOrContact(string guestName, string contact)
        {
            string sql = @"
        SELECT TOP 1 GuestID, FullName, Contact, LoyaltyNo, LoyaltyPoints
        FROM Guest
        WHERE FullName = @FullName OR Contact = @Contact;";

            SqlParameter[] parameters = {
                     new SqlParameter("@FullName", guestName),
                     new SqlParameter("@Contact", contact)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(sql, parameters);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckGuest_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text.Trim();
            string contact = txtContact.Text.Trim();

            if (string.IsNullOrEmpty(guestName) && string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please enter either the guest name or contact number first.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                        

            // Try to find an existing guest
            DataRow guest = GetGuestByNameOrContact(guestName, contact);

            if (guest != null)
            {
                // Guest found
                txtGuestName.Text = guest["FullName"].ToString();
                txtContact.Text = guest["Contact"].ToString();

                MessageBox.Show(
                    $"Guest found!\n\n" +
                    $"Name: {guest["FullName"]}\n" +
                    $"Contact: {guest["Contact"]}\n" +
                    $"Loyalty No: {guest["LoyaltyNo"]}\n" +
                    $"Loyalty Points: {guest["LoyaltyPoints"]}",
                    "Existing Guest",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ToggleBookingFields(true);
            }
            else
            {
                // ❌ Guest not found — let user create a new one
                DialogResult result = MessageBox.Show(
                    "Guest not found. Would you like to create a new record for this guest?",
                    "New Guest",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Allow creation of new guest and booking
                    ToggleBookingFields(true);
                }
                else
                {
                    this.Close();
                    // Stay hidden if they cancel
                    ToggleBookingFields(false);
                }
            }
        }
    }

}


