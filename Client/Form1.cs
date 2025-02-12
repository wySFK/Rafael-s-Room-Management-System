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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-BGNLUMC;Initial Catalog=RoomMdb;Integrated Security=True";
        private void RedRegis_Click(object sender, EventArgs e)
        {
            Register register= new Register();
            register.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
        

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("ValidateUserCredentials", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

   
                    command.Parameters.Add(new SqlParameter("@Username", Username.Text));
                    command.Parameters.Add(new SqlParameter("@Password", Password.Text));

                    try
                    {
                        string result = command.ExecuteScalar() as string;

                        if (result == "Valid")
                        {
                            
                            MessageBox.Show("Login successful.");
                            AdminMenu adminMenu = new AdminMenu();  
                            adminMenu.Show();
                            this.Hide();
                        }
                        else
                        {
           
                            MessageBox.Show("Login failed. Please check your username and password.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);

                    }
                    finally { connection.Close(); }
                }
            }
            }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
