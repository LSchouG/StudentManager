using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace StudentManager
{
    internal class StudentClass
    {
        DBconnect DBconnect = new DBconnect();

        // function to insert a new student
        public bool insertStudent(string firstName, string lastName, DateTime birthDate, string phone, string gender, string address, Byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO Student (StdFirstName, StdLastName, StdBirthDay, StdGender, StdPhone, StdAddress, StdImage)" +
                                                    " VALUES (@fn, @ln, @bd, @ph, @gen, @adr, @img)", DBconnect.getConnection);

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;

            DBconnect.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                DBconnect.closeConnection();
                return true;
            } else
            {
                DBconnect.closeConnection();
                return false;
            }
        }

        // function to load student from table
        public DataTable getStudentList()
        {
            MySqlCommand command = new MySqlCommand( "SELECT * FROM Student",  DBconnect.getConnection );

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


    }
}
