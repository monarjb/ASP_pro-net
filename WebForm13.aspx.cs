using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webtamrin1
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
        
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("ghaza.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            Response.Redirect("kartablrep2.aspx");
            }
            catch (Exception exception)
            {
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("Webform11.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            if (Session["uid"].ToString() == "admin")
           
            Response.Redirect("createform.aspx");
            }
            catch (Exception exception)
            {
            }
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            //if (Session["uid"].ToString() == "admin")
            //    Response.Redirect("Webform14.aspx");
            try {            Response.Redirect("karbari.aspx");
            }
            catch (Exception exception)
            {
            }
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
         
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            if (Session["uid"].ToString() == "admin")
                Response.Redirect("edit1.aspx");
            }
            catch (Exception exception)
            {
            }
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("vosolusr2.aspx");
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            if  (Session["uid"].ToString()!="sherkat")
            Response.Redirect("kartablrep1.aspx");
            }
            catch (Exception exception)
            {
            }
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            Response.Redirect("login.aspx");
            }
            catch (Exception exception)
            {
            }
        }
    }
}