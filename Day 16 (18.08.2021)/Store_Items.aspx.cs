using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day18
{
    public partial class Store_Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = ListBox1.SelectedValue;
            if (TextBox1.Text != null)
            {
                TextBox1.Text = null;
                TextBox2.Text = null;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItem.Text == "Soap")
            {
                TextBox1.Text = "50";
            }
            else if(ListBox1.SelectedItem.Text == "Biscuit")
            {
                TextBox1.Text = "20";
            }
            else if (ListBox1.SelectedItem.Text == "Salt")
            {
                TextBox1.Text = "10";
            }
            else if (ListBox1.SelectedItem.Text == "Cooking Oil")
            {
                TextBox1.Text = "200";
            }
            else if (ListBox1.SelectedItem.Text == "Shampoo")
            {
                TextBox1.Text = "150";
            }
            else if (ListBox1.SelectedItem.Text == "Chocolates")
            {
                TextBox1.Text = "60";
            }
        }
    }
}