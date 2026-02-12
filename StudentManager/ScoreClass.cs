using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;


namespace StudentManager
{
    internal class ScoreClass
    {
        DBconnect DBconnect = new DBconnect();

        // Function to insert courses
        public bool insertScore(int StudentID, string CourseName, double Score, string Description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`StudentID`, `CourseName`, `Score`, `Description`)" +
                                                    " VALUES (@StudentID, @CourseName, @Score, @Description)", DBconnect.getConnection);

            command.Parameters.Add("@StudentID", MySqlDbType.Int32).Value = StudentID;
            command.Parameters.Add("@CourseName", MySqlDbType.VarChar).Value = CourseName;
            command.Parameters.Add("@Score", MySqlDbType.Double).Value = Score;
            command.Parameters.Add("@Description", MySqlDbType.VarChar).Value = Description;

            DBconnect.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                DBconnect.closeConnection();
                return true;
            }
            else
            {
                DBconnect.closeConnection();
                return false;
            }
        }


        // Function to insert courses to table
        public DataTable getScoreList(MySqlCommand command)
        {
            // Assign connection if not already set
            if (command.Connection == null)
            {
                command.Connection = DBconnect.getConnection;
            }


            // Open connection if it’s closed
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool DeleteScore(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `StudentID` = @id", DBconnect.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            DBconnect.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                DBconnect.closeConnection();
                return true;
            }
            else
            {
                DBconnect.closeConnection();
                return false;
            }
        }

        public bool UpdateScore(int id, string courseName, int score, string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `CourseName`= @courseName,`Score`= @score,`Description`= @description" +
                                                    " WHERE `StudentID`= @id", DBconnect.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@courseName", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@score", MySqlDbType.Int32).Value = score;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;


            DBconnect.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                DBconnect.closeConnection();
                return true;
            }
            else
            {
                DBconnect.closeConnection();
                return false;
            }
        }



    }
}
