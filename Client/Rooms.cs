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
    public partial class Rooms : Form
    {
        private string connectionString = "Data Source=DESKTOP-BGNLUMC;Initial Catalog=RoomMdb;Integrated Security=True";
        public Rooms()
        {
            InitializeComponent();
            LoadRoomData();

        }
        private void RefreshTable()
        {
            LoadRoomData();
        }
        private void Rooms_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int capacity = Convert.ToInt32(Capacity.Text);
                decimal price = Convert.ToDecimal(Price.Text);
                int roomNum = Convert.ToInt32(RoomNum.Text);

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertRoom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RoomNum", roomNum);
                        command.Parameters.AddWithValue("@RoomName", RoomName.Text);
                        command.Parameters.AddWithValue("@Capacity", capacity);
                        command.Parameters.AddWithValue("@IsAvailable", Avail.Text);
                        command.Parameters.AddWithValue("@Description", Desc.Text);
                        command.Parameters.AddWithValue("@Price", price);

                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("New Room has been added...");
                            RefreshTable();
                        }
                        else
                        {
                            MessageBox.Show("Fail to add room, please try again.");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void RoomTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadRoomData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT RoomID, RoomNum, RoomName, Capacity, IsAvailable, Description, Price FROM Rooms";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            RoomTable.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            int roomIDToView = Convert.ToInt32(RoomID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT RoomNum, RoomName, Capacity, IsAvailable, Description, Price FROM Rooms WHERE RoomID = @RoomID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomID", roomIDToView);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Avail.Text = reader["IsAvailable"].ToString();
                                RoomNum.Text = reader["RoomNum"].ToString();
                                Capacity.Text = reader["Capacity"].ToString();
                                Desc.Text = reader["Description"].ToString();
                                Price.Text = reader["Price"].ToString();
                                RoomName.Text = reader["RoomName"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Room not found.");
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


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
   
                int roomIDToDelete =  Convert.ToInt32(RoomID.Text);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DeleteRoomWithAssignmentByRoomID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RoomID", roomIDToDelete);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Room with RoomID {roomIDToDelete} and its assignments have been deleted.");
                        RefreshTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting room: {ex.Message}");
                        }
                    }
                }
           
        }


        private void RoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int roomID = int.Parse(RoomID.Text);
            int roomNum = int.Parse(RoomNum.Text);
            string roomName = RoomName.Text;
            int capacity = int.Parse(Capacity.Text);
            string isAvailable = Avail.Text;
            string description = Desc.Text;
            decimal price = decimal.Parse(Price.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the new room number already exists
                if (RoomNumberExists(connection, roomID, roomNum))
                {
                    MessageBox.Show("Room number already exists. Please use a different room number.");
                }
                else
                {
                    using (SqlCommand command = new SqlCommand("UpdateRoom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@RoomID", roomID));
                        command.Parameters.Add(new SqlParameter("@RoomNum", roomNum));
                        command.Parameters.Add(new SqlParameter("@RoomName", roomName));
                        command.Parameters.Add(new SqlParameter("@Capacity", capacity));
                        command.Parameters.Add(new SqlParameter("@IsAvailable", isAvailable));
                        command.Parameters.Add(new SqlParameter("@Description", description));
                        command.Parameters.Add(new SqlParameter("@Price", price));

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Room updated successfully.");
                            RefreshTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating room: " + ex.Message);
                        }
                    }
                }
            }
        }

        private bool RoomNumberExists(SqlConnection connection, int roomID, int newRoomNum)
        {
            // Check if the new room number already exists, excluding the current room being updated
            using (SqlCommand checkCommand = new SqlCommand("SELECT 1 FROM Rooms WHERE RoomNum = @RoomNum AND RoomID <> @RoomID", connection))
            {
                checkCommand.Parameters.Add(new SqlParameter("@RoomNum", newRoomNum));
                checkCommand.Parameters.Add(new SqlParameter("@RoomID", roomID));
                return checkCommand.ExecuteScalar() != null;
            }
        }

        private void Rooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Rooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
    }
}
