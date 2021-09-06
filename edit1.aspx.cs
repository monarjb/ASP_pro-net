using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Webtamrin1
{
    public partial class edit1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["uid"] == null)
                    Response.Redirect("login.aspx");
            }
            catch (Exception exception)
            {
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
            con.Open();

            SqlCommand comm2 = new SqlCommand(" select * from  tbl_main  where  id='"+TextBox1.Text+"'", con);
                 //     comm2.Parameters.AddWithValue("@ID", TextBox1.Text);
             
                if (TextBox1.Text != "")
            {
                comm2.ExecuteNonQuery();
                con.Close();
              //  Response.Redirect("kartabl.aspx");
            }


            


            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(comm2);
          //  comm2.Parameters.AddWithValue("p1", Request.QueryString["id"].ToString());

            da2.Fill(dt2);


            if (dt2.Rows.Count > 0)
            {
                TextBox2.Text = dt2.Rows[0]["cmelli"].ToString();
                TextBox3.Text = dt2.Rows[0]["famil"].ToString();
                TextBox4.Text = dt2.Rows[0]["shenase"].ToString();
                TextBox5.Text = dt2.Rows[0]["cposti"].ToString();


                TextBox6.Text = dt2.Rows[0]["date1"].ToString();
                TextBox7.Text = dt2.Rows[0]["f62"].ToString();
                TextBox8.Text = dt2.Rows[0]["address"].ToString();
            }
        }
            catch (Exception exception)
            {
            }
}

        protected void Button2_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
            con.Open();

            SqlCommand comm2 = new SqlCommand(" update tbl_main set cmelli='"+TextBox2.Text+ "'  ,  famil=N'" + TextBox3.Text + "'  ,  shenase='" + TextBox4.Text + "'  , cposti='" + TextBox5.Text + "'  , date1='" + TextBox6.Text + "'  ,  f62='" + TextBox7.Text + "'  ,   address=N'" + TextBox8.Text + "'    where step=0 and id='" + TextBox1.Text + "'", con);
            comm2.ExecuteNonQuery();
            con.Close();
        }
            catch (Exception exception)
            {
            }
}

        protected void Button3_Click(object sender, EventArgs e)
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