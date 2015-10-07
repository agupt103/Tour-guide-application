using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TourGuideApp.TopTenContentReference;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client ip = new Service1Client();       //creates a service client object
            string t = TextBox1.Text;                         //Stores the input string
            if (t.Trim() == "" || t.Trim() == "." || t.Trim() == "-")                     // Validates for the empty string
            {
                HttpContext.Current.Response.Write("Please enter a valid Integer");
                return;
            }

            else
            {
                Label3.Text = String.Join(" > ", ip.GetData(t));               
            }
        }
    }
}
