using RestAPI1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPI1.Controllers
{
    public class PersonController : ApiController
    {
        IList<Person> People = new List<Person>();
        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            Person x = new Person
            {
                ID = 1,
                FirstName = "Rob",
                LastName = "Panetta",
                Salary = 150000,
                StartDate = new DateTime(2000, 3, 20),
                EndDate = new DateTime(2016,3,20)

            };
            Person y = new Person
            {
                ID = 2,
                FirstName = "Frank",
                LastName = "Castle",
                Salary = 15000,
                StartDate = new DateTime(2016, 3, 20),
                EndDate = new DateTime(2018, 3, 20)

            };
            People.Add(x);
            People.Add(y);


            return People;
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            Person y = new Person
            {
                ID = id,
                FirstName = "Frank",
                LastName = "Castle",
                Salary = 15000,
                StartDate = new DateTime(2016, 3, 20),
                EndDate = new DateTime(2018, 3, 20)

            };
            return y;
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
