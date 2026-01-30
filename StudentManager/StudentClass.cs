using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;


namespace StudentManager
{
    internal class StudentClass
    {
        DBconnect DBconnect = new DBconnect();

        // function to insert a new student
        public bool insertStudent(string firstName, string lastName, DateTime birthDate, string phone, string gender, string address, Byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO Student (StdFirstName, StdLastName, StdBirthDay, StdGender, StdPhone, StdAddress, StdImage)" +
                                                    " VALUES (@fn, @ln, @bd, @gen, @ph, @adr, @img)", DBconnect.getConnection);

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
            MySqlCommand command = new MySqlCommand("SELECT * FROM Student", DBconnect.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        // Get total, male, andc female students count
        // function to get count
        public string exeCount(String query)
        {
            MySqlCommand command = new MySqlCommand(query, DBconnect.getConnection);
            DBconnect.openConnection();
            string count = command.ExecuteScalar().ToString();
            DBconnect.closeConnection();
            return count;
        }
        // function to get total students
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM Student");
        }
        // function to get total male
        public string totalMaleStudents() 
        {
            return exeCount("SELECT COUNT(*) FROM Student WHERE stdGender = 'male'");
        }
        // function to get total female
        public string totalFemaleStudents()
        {
            return exeCount("SELECT COUNT(*) FROM Student WHERE stdGender = 'female'");
        }
        // function to search for first name last name or adress.
        public DataTable SearchStudent(String searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Student WHERE CONCAT(`StdFirstName`,`StdLastName`,`StdAddress`) LIKE @search", DBconnect.getConnection);
            command.Parameters.AddWithValue("@search", "%" + searchData + "%");
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        // function to insert a new student
        public bool UpdateStudent(int id,string firstName, string lastName, DateTime birthDate, string phone, string gender, string address, Byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `StdFirstName`= @fn,`StdLastName`= @ln,`StdBirthDay`= @bd,`StdGender`= @gen," +
                                                    " `StdPhone`= @ph,`StdAddress`= @adr,`StdImage`= @img WHERE `StdId`= @id", DBconnect.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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
            }
            else
            {
                DBconnect.closeConnection();
                return false;
            }
        }

        // function to delete studen by id
        public bool DeleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `StdId`= @id", DBconnect.getConnection);

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

        // function for any sql command in StudentDB
        public DataTable GetList(MySqlCommand command)
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

    }
}
