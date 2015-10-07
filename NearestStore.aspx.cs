using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TourGuideApp.NearestStoreReference;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client ip = new Service1Client();
            string t = TextBox1.Text;         //Stores the input string
            string t2 = TextBox2.Text;
            if ((t.Trim() == "" || t.Trim() == "." || t.Trim() == "-") && (t2.Trim() == "" || t2.Trim() == "." || t2.Trim() == "-"))                     // Validates for the empty string
            {
                HttpContext.Current.Response.Write("Please enter a valid ZipCode");
                return;
            }
            else
            {
                string d = String.Join(" , ", ip.GetData(t, t2)); 
                if(string.IsNullOrEmpty(d))     //If no store available
                {Label4.Text = "No store available";
                }
                else
                Label4.Text = d;
                // ListBox1.DataSource = ip.GetData(t);
            }
        }
    }
}
