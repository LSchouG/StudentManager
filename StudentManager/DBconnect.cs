using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace StudentManager
{
    internal class DBconnect
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=studentdb");


        public MySqlConnection getConnection
        {
            get
            {
            return connection;
            }
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }


        public void closeConnection() {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }


    }
}
