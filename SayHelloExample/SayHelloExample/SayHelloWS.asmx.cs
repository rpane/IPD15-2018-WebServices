using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SayHelloExample
{
    /// <summary>
    /// Summary description for SayHelloWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class SayHelloWS : System.Web.Services.WebService
    {

        [WebMethod]
        private string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string SayHelloString(string firstName , string lastName)
        {
            return string.Format("Hello {0} {1}", firstName, lastName);
        }

        [WebMethod]
        public string SayHelloJson(string firstName , string lastName)
        {
            var data = new { Greeting = "Hello", Name = firstName + " " + lastName };

            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            return js.Serialize(data);
        }

        [WebMethod]
        public SayHello SayHelloObject(string firstName, string lastName)
        {
            // if we write the following code except for '{' , visual stadio recommend us to use '{'.
            SayHello sh = new SayHello
            {
                Greeting = "Hello",
                Name = string.Format("{0} {1}", firstName, lastName)
            };
            return sh;
        }

        [WebMethod]
        public List<SayHello> SayAllHelloObjects(string firstName , string lastName)
        {
            List<SayHello> hellos = new List<SayHello>();
            for(int i = 0; i < 3; i++)
            {
                hellos.Add(new SayHello { Greeting = "Hello",
                                          Name = firstName + " " +
                                          lastName + " " + i.ToString() });            
            }
            return hellos;
        }

        //inner Class
        public class SayHello
        {
            public string Greeting { get; set; }
            public string Name { get; set; }
        }
    }
    
}
