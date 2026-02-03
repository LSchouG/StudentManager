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
    internal class CourseClass
    {
        DBconnect DBconnect = new DBconnect();

        // Function to insert courses

        public bool insertCourse(string courseName, int courseHour, string courseDescription) 
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO course (CourseName, CourseHour, CourseDescription)" +
                                                    " VALUES (@courseName, @courseHour, @courseDescription)", DBconnect.getConnection);


            command.Parameters.Add("@courseName", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@courseHour", MySqlDbType.Int32).Value = courseHour;
            command.Parameters.Add("@courseDescription", MySqlDbType.VarChar).Value = courseDescription;

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
        public DataTable getCourseList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM course", DBconnect.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool UpdateCourse(int id, string courseName, int courseHour, string courseDescription)
        {
            MySqlCommand command = new MySqlCommand(
                "UPDATE course SET CourseName = @courseName, CourseHour = @courseHour, CourseDescription = @courseDescription " +
                "WHERE CourseId = @CourseId",
                DBconnect.getConnection
            );

            command.Parameters.Add("@CourseId", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@courseName", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@courseHour", MySqlDbType.Int32).Value = courseHour;
            command.Parameters.Add("@courseDescription", MySqlDbType.VarChar).Value = courseDescription;

            try
            {
                DBconnect.openConnection();
                int result = command.ExecuteNonQuery();
                return result == 1; // returns true if exactly one row updated
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Course Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DBconnect.closeConnection();
            }
        }

        // function to delete course by id
        public bool DeleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE CourseId`= @id", DBconnect.getConnection);

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

    }
}
