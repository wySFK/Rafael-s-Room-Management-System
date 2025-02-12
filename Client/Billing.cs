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
    public partial class Billing : Form
    {
        private string connectionString = "Data Source=DESKTOP-BGNLUMC;Initial Catalog=RoomMdb;Integrated Security=True";
        public Billing()
        {
            InitializeComponent();
            FetchTable();
            PayStat.Items.Add("Paid");
            PayStat.Items.Add("Unpaid");
        }
        public void RefreshLoad()
        {
            FetchTable();
        }
        private void Billing_Load(object sender, EventArgs e)
        {

        }
        private void FetchTable() 
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try 
                {
                    connection.Open();
                    string query = "SELECT * FROM Billing"; 
                    using(SqlCommand command = new SqlCommand(query, connection)) 
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            BillingTable.DataSource  = dataTable;   
                        }
                    
                    }


                }
                catch(Exception ex) {
                    MessageBox.Show("Error" + ex.Message);
                
                } finally { connection.Close(); }
            }
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            int billingID = int.Parse(BillingID.Text); // Assuming you have a text box for BillingID
            decimal additionalCharges = decimal.Parse(AddCharge.Text); // Assuming you have a text box for AdditionalCharges
            string paymentStatus = PayStat.SelectedItem.ToString(); // Get the selected item as a string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateBilling", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@BillingID", billingID));
                    command.Parameters.Add(new SqlParameter("@AdditionalCharges", additionalCharges));
                    command.Parameters.Add(new SqlParameter("@PaymentStatus", paymentStatus));

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Check-out successful. Billing record updated.");
                        RefreshLoad();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during check-out: " + ex.Message);
                    }
                }
            }
        }

        private void PayStat_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CalcAmt_Click(object sender, EventArgs e)
        {
            int billingID = int.Parse(BillingID.Text); // Assuming you have a text box for BillingID
            decimal additionalCharge = decimal.Parse(AddCharge.Text); // Assuming you have a text box for AdditionalCharge

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Fetch the RoomCharge from the database based on the BillingID
                decimal roomCharge = 0; // Initialize with a default value
                using (SqlCommand fetchRoomChargeCommand = new SqlCommand("SELECT RoomCharge FROM Billing WHERE BillingID = @BillingID", connection))
                {
                    fetchRoomChargeCommand.Parameters.Add(new SqlParameter("@BillingID", billingID));
                    roomCharge = (decimal)fetchRoomChargeCommand.ExecuteScalar();
                }

                using (SqlCommand command = new SqlCommand("SELECT dbo.CalculateTotalAmount(@RoomCharge, @AdditionalCharge)", connection))
                {
                    command.Parameters.Add(new SqlParameter("@RoomCharge", roomCharge));
                    command.Parameters.Add(new SqlParameter("@AdditionalCharge", additionalCharge));

                    try
                    {
                        decimal totalAmount = (decimal)command.ExecuteScalar();
                        TotalAmount.Text = totalAmount.ToString("0.00"); // Display the total amount with two decimal places
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error calculating total amount: " + ex.Message);
                    }
                }
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Billing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Billing_FormClosing(object sender, FormClosingEventArgs e)
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
