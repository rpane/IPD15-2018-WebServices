using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI1.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
      
    }
}