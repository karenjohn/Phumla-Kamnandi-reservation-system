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
    public partial class Enquiry : Form
    {
        public Enquiry()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBookings();
        }

        private void SearchBookings()
        {
            string searchTerm = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a guest name or reservation ID to search.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Using the correct Reservation schema
            string query = @"
                SELECT 
                    r.ResID,
                    g.FullName,
                    r.RoomID,
                    r.CheckInDate,
                    r.CheckOutDate,
                    r.Status,
                    rm.RoomType,
                    rm.Rate,
                    r.NumGuests,
                    r.DepositAmount
                FROM Reservation r
                INNER JOIN Guest g ON r.GuestID = g.GuestID
                INNER JOIN Room rm ON r.RoomID = rm.RoomID
                WHERE 
                    g.FullName LIKE @Search
                    OR CAST(r.ResID AS NVARCHAR) LIKE @Search
                ORDER BY r.CheckInDate;";

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query,
                    new SqlParameter("@Search", $"%{searchTerm}%"));

                lvResults.Items.Clear();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No reservations found for the given search term.",
                        "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["ResID"].ToString());
                    item.SubItems.Add(row["FullName"].ToString());
                    item.SubItems.Add(row["RoomID"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["CheckInDate"]).ToString("yyyy/MM/dd"));
                    item.SubItems.Add(Convert.ToDateTime(row["CheckOutDate"]).ToString("yyyy/MM/dd"));
                    item.SubItems.Add(row["Status"].ToString());
                    item.SubItems.Add(row["RoomType"].ToString());
                    item.SubItems.Add(row["Rate"].ToString());
                    item.SubItems.Add(row["NumGuests"].ToString());
                    item.SubItems.Add(row["DepositAmount"].ToString());
                    lvResults.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving reservation data:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {// Close button closes the form
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
