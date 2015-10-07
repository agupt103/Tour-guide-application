using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TourGuideApp.AtmReference;

namespace BankApp
{
    public partial class BankForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label4.Text = null;
            BankServiceClient ip = new BankServiceClient();
           
            int t1 = 0;
            string name = null;
            string t = TextBox1.Text;         //Stores the input string

            if (t.Trim() == "" || t.Trim() == "." || t.Trim() == "-")
            {

                RegisterStartupScript("startupScript", "<script language=JavaScript>alert('Please enter a valid ZipCode or Address');</script>");

            }
            else
            {
                string d = String.Join("", ip.GetData(name, t, t1));
                if (string.IsNullOrEmpty(d))     //If no store available
                {
                    Label4.Text = "Please find the ATMs first";
                    //ViewState["Acc"] = 1;
                }
                else
                {
                    Label4.Text = d;
                    // ViewState["Acc"] = 1;
                }
            }
        }


        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int t3 = 1;
            Label6.Text = null;
            if (Label4.Text == null)
            {
                RegisterStartupScript("startupScript", "<script language=JavaScript>alert('Please find the Bus stations first....');</script>");
            }
            BankServiceClient ip1 = new BankServiceClient();
            string t1 = TextBox1.Text;
            string t2 = TextBox2.Text;         //Stores the input string
            string d = null;
            if (t2.Trim() == "" || t2.Trim() == "." || t2.Trim() == "-")
            {
                RegisterStartupScript("startupScript", "<script language=JavaScript>alert('Please enter a valid name from the list');</script>");
            }
            else
            {
                d = String.Join("", ip1.GetData(t2, t1, t3));
            }
            if (string.IsNullOrEmpty(d))     //If no store available
            {
                Label6.Text = "No address avaliable";

            }
            else
            {
                Label6.Text = d;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int t3 = 2;

            if (Label4.Text == null)
            {
                RegisterStartupScript("startupScript", "<script language=JavaScript>alert('Please find the Bus stations first....');</script>");
            }
           BankServiceClient ip1 = new BankServiceClient();
            string t1 = TextBox1.Text;
            string t2 = TextBox2.Text;         //Stores the input string
            string d = null;
            if (t2.Trim() == "" || t2.Trim() == "." || t2.Trim() == "-")
            {
                RegisterStartupScript("startupScript", "<script language=JavaScript>alert('Please enter a valid name from the list');</script>");
            }
            else
            {
                d = String.Join("", ip1.GetData(t2, t1, t3));
            }
            if (string.IsNullOrEmpty(d))     //If no store available
            {
                Label7.Text = "No Number available";

            }
            else
            {
                Label7.Text = d;

            }
        }

    }
}
