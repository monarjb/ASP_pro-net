using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Webtamrin1
{
    public partial class karbari : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
            if (Session["uid"] == null)
                Response.Redirect("login.aspx");
            Label1.Text = Session["uid"].ToString();
        }
            catch (Exception exception)
            {
            }
}

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            if (TextBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
                con.Open();

                SqlCommand comm2 = new SqlCommand("update tbl_user set pass=@p1  where usr=@p2", con);

                    comm2.Parameters.AddWithValue("@p1", TextBox1.Text);

                    comm2.Parameters.AddWithValue("@p2", Label1.Text);
                    comm2.ExecuteNonQuery();
                con.Close();
                Response.Redirect("webform13.aspx");
            }
        }
            catch (Exception exception)
            {
            }
}

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            Response.Redirect("webform13.aspx");
            }
            catch (Exception exception)
            {
            }
        }
    }
}