using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SayHelloExampleWS
{
    /// <summary>
    /// Summary description for SayHelloWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SayHelloWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string SayHelloStr(string fname, string lname)
        {
            return string.Format("Hello, {0} {1}",fname,lname);
        }

        [WebMethod]
        public string SayHelloJson(string fname, string lname)
        {
            var data = new { Greeting = "Hello", Name = fname + " " + lname };

            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            return js.Serialize(data);
        }

        [WebMethod]
        public SayHello SayHelloObject(string fname, string lname)
        {
            SayHello x = new SayHello
            {
                Greeting = "Hello",
                Name = string.Format("Hello, {0} {1}", fname, lname)
            };

            return x;
        }

        [WebMethod]
        public IList<SayHello> SayHelloObjs(string fname, string lname)
        {
            IList<SayHello> hellos = new List<SayHello>();
            for(int i =0; i < 3; i++)
            {
                hellos.Add(new SayHello { Greeting = "Hello", Name = fname + " " + lname + " " + i.ToString() });
            }
            return hellos;
        }


        public class SayHello
        {
            public string Greeting { get; set; }
            public string Name { get; set; }
        }
    }
    
}
