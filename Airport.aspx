using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using System.Text;
using System.Net;

using System.Xml;
using System.Xml.XPath;
using System.IO;


namespace WebApplication4
{
    
    public partial class Default : System.Web.UI.Page
    {
        static string r;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url = "http://webstrar32.fulton.asu.edu/page1/AirportServices.svc/GetData?c=" + TextBox1.Text;
            List<string> a = new List<string>();
            XmlTextReader reader = new XmlTextReader(url);
           
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                   

                    case XmlNodeType.Text: //Display the text in each element.
                        a.Add(reader.Value + "<br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp");
                   //     Console.WriteLine(reader.Value);
                        break;

                   
                }
            }
            
            string d = String.Join("", a);
            
          //  string result = d.Replace(",", Environment.NewLine);
            Label4.Text = d.ToString();
        }

       
        }
          
        
        

    }
   
