using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day18
{
    public partial class ButtonImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "~/Images/bs-01.jpg";
        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "~/Images/image2.jpeg";
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "~/Images/images.jpeg";
        }
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = null;
        }

    }
}