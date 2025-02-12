using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void RoomRed_Click(object sender, EventArgs e)
        {
            Rooms rooms= new Rooms();
            rooms.Show();
            this.Hide();

        }

        private void TenRed_Click(object sender, EventArgs e)
        {
            RoomAssignment tenant = new RoomAssignment();
            tenant.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Users users= new Users();   
            users.Show();
            this.Hide();

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
