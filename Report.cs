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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime from = dtpFrom.Value;
                DateTime to = dtpTo.Value;

                if (to <= from)
                {
                    MessageBox.Show("The 'To' date must be after the 'From' date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SQL query: calculate daily occupancy (percentage of booked rooms)
                string query = @"
                    SELECT 
                CAST(r.CheckInDate AS DATE) AS [Date],
                COUNT(DISTINCT r.RoomID) AS BookedRooms,
                (SELECT COUNT(RoomID) FROM Room WHERE AvailabilityStatus = 'Available') 
                    - COUNT(DISTINCT r.RoomID) AS AvailableRooms,
                CAST(
                    COUNT(DISTINCT r.RoomID) * 100.0 /
                    (SELECT COUNT(RoomID) FROM Room WHERE AvailabilityStatus = 'Available')
                AS DECIMAL(5, 2)) AS OccupancyPercent
            FROM 
                Reservation r
                INNER JOIN Room rm ON r.RoomID = rm.RoomID
            WHERE 
                r.CheckInDate BETWEEN @From AND @To
                AND r.Status = 'Confirmed'
            GROUP BY 
                CAST(r.CheckInDate AS DATE)
            ORDER BY 
                [Date];";

                // Execute query and fetch data
                DataTable dt = ExecuteQuery(query, new SqlParameter("@From", from), new SqlParameter("@To", to));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No bookings found in the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Bind to DataGridView
                dgvReport.DataSource = dt;
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            // Adjust connection string 
            string connectionString = Properties.Settings.Default.HotelDatabaseConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

