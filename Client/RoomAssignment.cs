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

namespace Client
{
    public partial class RoomAssignment : Form
    {
        private string connectionString = "Data Source=DESKTOP-BGNLUMC;Initial Catalog=RoomMdb;Integrated Security=True";

        public RoomAssignment()
        {
            InitializeComponent();
            GetRoomNum();
            FetchRoomAss();
            RoomAvailText_Click(null, EventArgs.Empty);
            LoadOccupiedRoomCount();
        }

        private void Refresh() 
        { 
            FetchRoomAss();
        }
        private void GetRoomNum()
        {
            Assig.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT RoomNum FROM Rooms";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Assig.Items.Add(reader["RoomNum"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void PayAmount_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectedRoomNumber = Assig.SelectedItem.ToString();

                    using (SqlCommand command = new SqlCommand("InsertGuestReservation", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@GuestName", Guestname.Text);
                            command.Parameters.AddWithValue("@CheckInDate", CinDate.Value);
                            command.Parameters.AddWithValue("@CheckOutDate", CoutDate.Value);
                            command.Parameters.AddWithValue("@RoomNumber",selectedRoomNumber);
                            command.Parameters.AddWithValue("@RoomCharge", Total.Text);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data inserted into RoomAssignment table.");
                                Refresh();
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert data. Please try again.");
                            }
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    
        private decimal GetRoomPriceByRoomNum(int roomNum, SqlConnection connection)
        {
            decimal pricePerNight = -1;

            string query = "SELECT Price FROM Rooms WHERE RoomNum = @RoomNum";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RoomNum", roomNum);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pricePerNight = reader.GetDecimal(0);
                    }
                }
            }

            return pricePerNight;
        }
        private void CalcTotalRent_Click(object sender, EventArgs e)
        {
            DateTime checkIn = CinDate.Value;
            DateTime checkOut = CoutDate.Value;

            if (checkIn > checkOut)
            {
                MessageBox.Show("Check-out date cannot be before check-in date.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Calculate the interval in days.
                TimeSpan interval = checkOut - checkIn;
                int totalDays = interval.Days;

                // Get the selected room number from the ComboBox.
                if (Assig.SelectedItem == null || !int.TryParse(Assig.SelectedItem.ToString(), out int roomNum))
                {
                    MessageBox.Show("Please select a valid room number.");
                    return;
                }

                // Check if the selected room is available
                if (!IsRoomAvailable(roomNum, connection))
                {
                    MessageBox.Show("Room is already taken. Please select another room.");
                    return;
                }

                decimal pricePerNight = GetRoomPriceByRoomNum(roomNum, connection);

                if (pricePerNight < 0)
                {
                    MessageBox.Show("Invalid room number. Please enter a valid room number.");
                    return;
                }

                decimal totalRent = totalDays * pricePerNight;
                Total.Text = totalRent.ToString(); // Display as currency format.
            }
        }

        private bool IsRoomAvailable(int roomNum, SqlConnection connection)
        {
            string query = "SELECT IsAvailable FROM Rooms WHERE RoomNum = @RoomNum";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RoomNum", roomNum);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetBoolean(0); // Return true if the room is available (IsAvailable = 1).
                    }
                }
            }

            return false; // Default to false if room not found or IsAvailable is not 1.
        }

        private void RoomAssignTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FetchRoomAss()
        {
            using(SqlConnection connection= new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT AssignmentID, RoomID, RoomNumber, GuestName, CheckInDate, CheckOutDate, TotalPrice FROM RoomAssignment ";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable= new DataTable();
                        adapter.Fill(dataTable);
                        RoomAssignTable.DataSource = dataTable; 
                    }
                }
            }
        }

        private int GetAvailableRoomCount()
        {
            int availableRoomCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT dbo.CountAvailableRooms()", connection))
                {
                    try
                    {
                        availableRoomCount = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error counting available rooms: " + ex.Message);
                    }
                }
            }

            return availableRoomCount;
        }

        private void RoomAvailText_Click(object sender, EventArgs e)
        {
            int availableRoomCount = GetAvailableRoomCount();
            RoomAvailText.Text = "Available Rooms: " + availableRoomCount.ToString();
        }

            private void RoomOcc_Click(object sender, EventArgs e)
            {
              
            }

           
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadOccupiedRoomCount()
        {
            int occupiedRoomCount = GetOccupiedRoomCount();
            RoomOcc.Text = $"Total occupied rooms: {occupiedRoomCount}";
        }

        private int GetOccupiedRoomCount()
        {
            int occupiedRoomCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT dbo.CountOccupiedRooms()", connection))
                {
                    try
                    {
                        occupiedRoomCount = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error counting occupied rooms: " + ex.Message);
                    }
                }
            }

            return occupiedRoomCount;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu AdminMenu = new AdminMenu();
            AdminMenu.Show();
            this.Hide();
        }

        private void RoomAssignment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RoomAssignment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}