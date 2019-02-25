using Newtonsoft.Json;
using RestfulAPI1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestfulAPI1.Controllers
{
    public class PersonController : ApiController
    {
        PersonDatabaseContext db = new PersonDatabaseContext();
        

        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            
            List<Person> test = db.GetAllPeople();
            return test;
        }

        // GET: api/Person/5
        public Person Get(int id)
        {           
            return db.GetPersonById(id);
        }

        // POST: api/Person       
        public void Post([FromBody]string value)
        {
            var myJsonObj = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(value);
            var FName = myJsonObj["FirstName"];
            var LName = myJsonObj["LastName"];
            var Sal = myJsonObj["Salary"];
            var StarD = myJsonObj["StartDate"];
            var EndD = myJsonObj["EndDate"];
            Person x = new Person(FName, LName, Sal,StarD,EndD);
            db.AddPerson(x);

        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
            db.DeletePerson(id);
        }
    }
}
