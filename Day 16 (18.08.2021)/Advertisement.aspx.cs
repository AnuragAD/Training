using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day18
{
    public partial class Advertisement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Amazon_lbtn_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.amazon.in/");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.fabmart.com/");
        }
    }
}