using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_9
{
    public partial class GoldSilver : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Visible = false;
            ListBox2.Visible = false;
            ListBox3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Metal"] = DropDownList1.SelectedItem.Text;
            if (Session["Metal"].Equals("Gold"))
            {
                ListBox1.Visible = true;
                ListBox2.Visible = false;
                ListBox3.Visible = false;
            }
            else if (Session["Metal"].Equals("Silver"))
            {
                ListBox1.Visible = false;
                ListBox2.Visible = true;
                ListBox3.Visible = false;
            }
            else if (Session["Metal"].Equals("Diamond"))
            {
                ListBox1.Visible = false;
                ListBox2.Visible = false;
                ListBox3.Visible = true;
            }
        }
    }
}