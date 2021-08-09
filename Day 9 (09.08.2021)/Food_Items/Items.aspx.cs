using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_9
{
    public partial class Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Food"].Equals("BreakFast"))
                {
                    Response.Write("Todays Break Fast List is:");
                    ArrayList Al = new ArrayList();
                    Al.Add("Idli");
                    Al.Add("Dosa");
                    Al.Add("Puri");
                    Al.Add("Poha");
                    foreach(string AL in Al)
                    {
                        Response.Write("\n" + AL);
                    }
                }
                if (Session["Food"].Equals("Lunch"))
                {
                    Response.Write("Available Lunch is:");
                    ArrayList Al = new ArrayList();
                    Al.Add("Dal");
                    Al.Add("Rice");
                    Al.Add("Paneer");
                    Al.Add("Roti");
                    foreach (string AL in Al)
                    {
                        Response.Write("\n" + AL);
                    }
                }
                if (Session["Food"].Equals("Snacks"))
                {
                    Response.Write("Todays Break Fast List is:");
                    ArrayList Al = new ArrayList();
                    Al.Add("Tea");
                    Al.Add("Biscuit");
                    Al.Add("Coffee");
                    Al.Add("Haldiram Namkeen");
                    foreach (string AL in Al)
                    {
                        Response.Write("\n" + AL);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}