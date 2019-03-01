using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JACClient
{
    public partial class Student
    {
       
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> EnrollmentDate { get; set; }     
    }
}