using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day18
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label6.Visible = false;
            Label7.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedItem.Text == "Male")
            {
                Label6.Text = "Thanks Mr. " + TextBox1.Text + " for your feedback";
                Label6.Visible = true;
            }
            else
            {
                Label7.Text = "Thanks Miss. " + TextBox1.Text + " for your feedback";
                Label7.Visible = true;
            }
        }
    }
}