using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day7
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "Andaman and Nicobar Islands")
            {
                ListBox1.Items.Add("Port Blair");
                ListBox1.Items.Add("Arong");
                ListBox1.Items.Add("Manglutan");
                ListBox1.Items.Add("BombooFlat");
                ListBox1.Items.Add("Mayabunder");
                ListBox1.Items.Add("Digilpur");
                ListBox1.Items.Add("Perka");
            }
            else if (DropDownList1.SelectedValue == "Andhra Pradesh")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Anantapur");
                ListBox1.Items.Add("Chittoor");
                ListBox1.Items.Add("Guntur");
                ListBox1.Items.Add("Kurnool");
                ListBox1.Items.Add("Srikakulam");
                ListBox1.Items.Add("Visakhapatnam");
                ListBox1.Items.Add("West Godavari");
            }
            else if (DropDownList1.SelectedValue == "Arunachal Pradesh")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("City 1");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Himachal Pradesh")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("City 1");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Madhya Pradesh")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Satna");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Maharashtra")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Mumbai");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Manipur")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Imphal");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Meghalaya")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Nongstoin");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Mizoram")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Aziwal");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Nagaland")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Kohima");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Orissa")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Bhubneshwar");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Punjab")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Chandigarh");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Rajasthan")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Jaipur");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
            else if (DropDownList1.SelectedValue == "Sikkim")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Gangtok");
                ListBox1.Items.Add("City 2");
                ListBox1.Items.Add("City 3");
                ListBox1.Items.Add("City 4");
                ListBox1.Items.Add("City 5");
                ListBox1.Items.Add("City 6");
                ListBox1.Items.Add("City 7");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Clear();
            ListBox2.Items.Add(TextBox1.Text);
            ListBox2.Items.Add(TextBox2.Text);
            ListBox2.Items.Add(RadioButtonList1.SelectedItem.Text);
            ListBox2.Items.Add(TextBox3.Text);
            ListBox2.Items.Add(DropDownList1.SelectedValue);
            ListBox2.Items.Add(ListBox1.SelectedValue);
        }
    }
}
