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
    public partial class Users : Form
    {
        private string connectionString = "Data Source=DESKTOP-BGNLUMC;Initial Catalog=RoomMdb;Integrated Security=True";
        public Users()
        {
            InitializeComponent();
            FetchUser();
        }

        private void TableUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FetchUser()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserRegistration";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            TableUser.DataSource = dataTable;
                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);

                }
                finally { connection.Close(); }
            }
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

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}