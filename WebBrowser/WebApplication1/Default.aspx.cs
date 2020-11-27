using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TextBox1.Text)) //checks if the text box is empty
            {
                sortRef.ServiceClient sortRef = new sortRef.ServiceClient(); //creat the sort reference
                string s = sortRef.sort(TextBox1.Text); //call the sort method on the text in textbox 1
                Label1.Text = s.ToString(); //output the result as a string
            }
            else // if the textbos is empty display this
            {
                Label1.Text = "Please enter a string of numbers separated by commas";
            
            }
        }
    }
}