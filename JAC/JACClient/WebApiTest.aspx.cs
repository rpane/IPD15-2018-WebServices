using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace JACClient
{
    public partial class WebApiTest : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnSave_ClickAsync(object sender, EventArgs e)
        {

            Global.client.BaseAddress = new Uri("http://localhost:52542/");
            Global.client.DefaultRequestHeaders.Accept.Clear();
            Global.client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            Global.client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", "Um9iOjEyMzQ=");

            Student x = new Student();
            x.FirstName = tbFN.Text;
            x.LastName = tbLN.Text;
            x.EnrollmentDate = CalEnrol.SelectedDate;

            var url = SaveStudentAsync(x);
            Label4.Text = url.ToString();
           
            
        }

        async Task<Uri> SaveStudentAsync(Student stu)
        {
            HttpResponseMessage response = await Global.client.PostAsJsonAsync("api/Students", stu);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }
    }
}