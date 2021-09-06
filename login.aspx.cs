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
using System.Drawing.Imaging;


namespace Webtamrin1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
                    SqlCommand comm = new SqlCommand("select top 1 * from tbl_captcha order by NEWID()", con);
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TextBox3.Text = dt.Rows[0]["q"].ToString();
                }
            }
            catch (Exception exception)
            {
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

            SqlCommand comm55 = new SqlCommand("select * from tbl_captcha where q=@p1 and a=@p2", con);
            comm55.Parameters.AddWithValue("p1", TextBox3.Text);
            comm55.Parameters.AddWithValue("p2", TextBox4.Text);


            SqlDataAdapter da55 = new SqlDataAdapter(comm55);
            DataTable dt55 = new DataTable();
            da55.Fill(dt55);
            if (dt55.Rows.Count < 1)
            {
                //سوال امنیتی اشتباه ست
            }

            else
            {

                SqlCommand comm = new SqlCommand("select * from tbl_user where  usr=@p3 and pass=@p4 ", con);
                    comm.Parameters.AddWithValue("p3", TextBox1.Text);
                    comm.Parameters.AddWithValue("p4", TextBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    Session["hamzamani"] = dt.Rows[0]["hamzamani"].ToString();
                    Session["step"] = dt.Rows[0]["step"].ToString();
                    Session["uid"] = TextBox1.Text;
                    Session["shahr"] = dt.Rows[0]["shahr"].ToString().Trim();
                    Session["flag"] = dt.Rows[0]["flag"].ToString().Trim();
                    Response.Redirect("WebForm13.aspx");


                }


                else
                {
                    Label1.Text = "خطا در کلمه عبور ";
                }
            }
        }
            catch (Exception exception)
            {
            }
}

        protected void Button2_Click(object sender, EventArgs e)
        {

           
        }
    }
}