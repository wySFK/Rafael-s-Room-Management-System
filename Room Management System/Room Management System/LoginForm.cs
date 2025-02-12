using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Room_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLoginForm_Click_1(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username` =@usn AND `password`=@pass";
        
            command.CommandText = query;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@usn" ,MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 )
            {
               this.Hide();
                Main_Form mform = new Main_Form();
                mform.Show();
            }
            else
            {
                if (textBoxUsername.Text.Trim().Equals("")) 
                {
                    MessageBox.Show("Enter Your Username to login","Empty Username",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
