using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulAPI1.Models
{
    public class Person
    {
        int id;
        public Person(string firstName, string lastName, decimal salary, DateTime startDate, DateTime endDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int ID { get => id; set => id = value; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}