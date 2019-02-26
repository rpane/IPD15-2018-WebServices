using Organization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Organization.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            using (EmpModel db = new EmpModel())
            {
                return db.Employees.ToList();
            }
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            using (EmpModel db = new EmpModel())
            {
                return db.Employees.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        // POST: api/Employee
        public void Post([FromBody]Employee value)
        {
            using (EmpModel db = new EmpModel())
            {
                db.Employees.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]Employee value)
        {
            using (EmpModel db = new EmpModel())
            {
                Employee y = db.Employees.Where(x => x.Id == id).FirstOrDefault();
                if(y != null)
                {
                    y.FirstName = value.FirstName;
                    y.LastName = value.LastName;
                    y.Salary = value.Salary;
                    y.Email = value.Email;
                    y.StartDate = value.StartDate;
                    y.EndDate = value.EndDate;
                    y.Title = value.Title;                    
                    db.SaveChanges();
                }
                
            }
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
            using (EmpModel db = new EmpModel())
            {
                db.Employees.Remove(db.Employees.Where(x => x.Id == id).FirstOrDefault());
                db.SaveChanges();
            }
        }
    }
}
