using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_8
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
            if(TextBox6.Text == TextBox7.Text)
            {
                ArrayList Al = new ArrayList();
                Al.Add(TextBox1.Text);
                Al.Add(TextBox2.Text);
                if(RadioButtonList1.SelectedValue == "")
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>alert(\"Please select your Gender.\");</script>", false);
                    return;
                }
                else
                {
                    Al.Add(RadioButtonList1.SelectedItem.Text);
                }
                if (RadioButtonList2.SelectedValue == "")
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>alert(\"Please select your Marital Status.\");</script>", false);
                    return;
                }
                else
                {
                    Al.Add(RadioButtonList2.SelectedItem.Text);
                }
                Al.Add(TextBox3.Text);
                Al.Add(TextBox4.Text);
                Al.Add(TextBox5.Text);
                Al.Add(TextBox6.Text);
                if(CheckBoxList1.SelectedValue == "")
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>alert(\"Please Select Atleast One Occupation.\");</script>", false);
                    return;
                }
                else
                {
                    foreach (ListItem AL in CheckBoxList1.Items)
                    {
                        if (AL.Selected == true)
                            Al.Add(AL.Text);

                    }
                }
                FileStream fs = new FileStream("E:/Training/files/form_data1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                foreach (string s in Al)
                {
                    sw.Write(s + "\n");
                }
                sw.Flush();
                sw.Close();
                fs.Close();
                Response.Redirect("Success.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>alert(\"Password Did not Matched.\");</script>", false);
                return;
            }
            
        }
    }
}