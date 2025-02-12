using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Room_Management_System
{
    /*
    this class connects forms to sql database

     */
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Csharp_Room_DB");

        public MySqlConnection GetConnection()
        {
            return connection;
        }
     /*open connection*/
        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed) 
            {
                connection.Open();
            }
        }
     /*close connection*/
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
