using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAPWebServices
{
    /// <summary>
    /// Summary description for Calculate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculate : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double Calculation(double x, double y, string operation)
        {
            double result;
            //Validate


            if (y == 0 && operation == "/")
            {
                return -1;
            }

            switch (operation)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                default:
                    result = -2;
                    break;
            }

            return result;
        }

        [WebMethod]
        public string SayGoodBye(string name)
        {
            return string.Format("Good bye from {0}",name);
        }
    }
}
