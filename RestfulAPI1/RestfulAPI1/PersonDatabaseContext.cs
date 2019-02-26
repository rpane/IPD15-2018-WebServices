using RestfulAPI1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace RestfulAPI1
{
    public class PersonDatabaseContext
    {
        //Home
        const string CONN_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Programming\\Web\\IPD15-2018-WebServices\\WSPeople.mdf;Integrated Security=True;Connect Timeout=30";
        
        //School
        //const string CONN_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\WebServices\\IPD15-2018-WebServices\\RestfulAPI1\\WebServicePeople.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        
        public PersonDatabaseContext()
        {
            // FIXME: Handle System.ArgumentException when conn_string is invalid
            conn = new SqlConnection(CONN_STRING);
            conn.Open();
        }
       

        public List<Person> GetAllPeople()
        {
            
                using (SqlCommand command = new SqlCommand("SELECT * FROM People", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Person> result = new List<Person>();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string FirstName = (string)reader["FirstName"];
                            string LastName = (string)reader["LastName"];
                            decimal Salary = (decimal)reader["Salary"];
                            DateTime StartDate = (DateTime)reader["StartDate"];
                            DateTime EndDate = (DateTime)reader["EndDate"];
                            Person p = new Person(FirstName, LastName, Salary, StartDate, EndDate);
                            p.ID = id;
                            result.Add(p);
                        }
                        return result;
                    }
                }                
        }

        public Person GetPersonById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM People WHERE Id=@id", conn);
            command.Parameters.AddWithValue("@id", id);
            
                using (SqlDataReader reader = command.ExecuteReader())
                {               
                    
                    if (reader.Read())
                    {
                        int Id = (int)reader["Id"];
                        string FirstName = (string)reader["FirstName"];
                        string LastName = (string)reader["LastName"];
                        decimal Salary = (decimal)reader["Salary"];
                        DateTime StartDate = (DateTime)reader["StartDate"];
                        DateTime EndDate = (DateTime)reader["EndDate"];
                        Person p = new Person(FirstName, LastName, Salary, StartDate, EndDate);
                        p.ID = Id;
                        return p;
                    }
                    else
                    {
                        return null;
                    }
                
            }
            
        }
        public void AddPerson(Person c)
        {
            using (SqlCommand insertCommand = new SqlCommand(
                "INSERT INTO People (FirstName, LastName, Salary, StartDate, EndDate) VALUES (@FirstName, @LastName, @Salary, @StartDate, @EndDate) ", conn))
            {
                insertCommand.Parameters.AddWithValue("@FirstName", c.FirstName);
                insertCommand.Parameters.AddWithValue("@LastName", c.LastName);
                insertCommand.Parameters.AddWithValue("@Salary", c.Salary);
                insertCommand.Parameters.AddWithValue("@StartDate", c.StartDate);
                insertCommand.Parameters.AddWithValue("@EndDate", c.EndDate);
                insertCommand.ExecuteNonQuery();
            }
        }

        public void UpdatePerson(int id,Person c)
        {
            using (SqlCommand updateCommand = new SqlCommand(
                "UPDATE People SET FirstName=@FirstName, LastName=@LastName, Salary=@Salary, StartDate=@StartDate, EndDate=@EndDate WHERE Id=@Id", conn))
            {
                updateCommand.Parameters.AddWithValue("@Id", id);
                updateCommand.Parameters.AddWithValue("@FirstName", c.FirstName);
                updateCommand.Parameters.AddWithValue("@LastName", c.LastName);
                updateCommand.Parameters.AddWithValue("@Salary", c.Salary);
                updateCommand.Parameters.AddWithValue("@StartDate", c.StartDate);
                updateCommand.Parameters.AddWithValue("@EndDate", c.EndDate);
                updateCommand.ExecuteNonQuery();
            }
        }

        public void DeletePerson(int id)
        {
            using (SqlCommand updateCommand = new SqlCommand(
                "DELETE FROM People WHERE Id=@Id", conn))
            {
                updateCommand.Parameters.AddWithValue("@Id", id);
                updateCommand.ExecuteNonQuery();
            }
        }
    }
}