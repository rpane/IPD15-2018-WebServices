using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SOAPClient
{
    public partial class CalculatorClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double result;
            string name;
            //Get first Number and second number and calculate
            CalculatorWebService.CalculateSoapClient client = new CalculatorWebService.CalculateSoapClient();
            result = client.Calculation(Double.Parse(TextBox1.Text), Double.Parse(TextBox2.Text), DropDownList1.SelectedValue);
            Label3.Text = result+"";

            name = client.SayGoodBye("Tom");
            Label4.Text = name;


        }
    }
}