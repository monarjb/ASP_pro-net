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
    public partial class kartablrep1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["uid"] == null)
            //    Response.Redirect("login.aspx");

            //Label3.Text = Session["shahr"].ToString();
            //if (Session["uid"].ToString() == "herasat")
            //{

            //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

            //    SqlCommand comm = new SqlCommand("select * from tbl_main where taraf like N'دو طرفه' order by id ", con);
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(comm);

            //    da.Fill(dt);

            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();


            //    if (dt.Rows.Count > 0)
            //    {
            //        Label1.Text = dt.Rows[0]["step"].ToString();

            //    }

            //    Session["step2"] = Label1.Text;
            //    Session["gozaresh"] = Label2.Text;
            //}
            //////////////////////////////////////
            //if (Session["flag"].ToString() == "1")////yani shahrestan
            //{

            //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

            //    SqlCommand comm = new SqlCommand("select * from tbl_main where bestar like N'سیم خصوصی' and shahr like N'"+Label3.Text+"' order by id ", con);
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(comm);

            //    da.Fill(dt);

            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();


            //    if (dt.Rows.Count > 0)
            //    {
            //        Label1.Text = dt.Rows[0]["step"].ToString();

            //    }

            //    Session["step2"] = Label1.Text;
            //    Session["gozaresh"] = Label2.Text;
            //}


            ///////////////////////
            //if ((Session["flag"].ToString() != "1") && (Session["uid"].ToString() != "herasat"))
            //{

            //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

            //    SqlCommand comm = new SqlCommand("select * from tbl_main   order by id ", con);
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(comm);

            //    da.Fill(dt);

            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();


            //    if (dt.Rows.Count > 0)
            //    {
            //        Label1.Text = dt.Rows[0]["step"].ToString();

            //    }

            //    Session["step2"] = Label1.Text;
            //    Session["gozaresh"] = Label2.Text;
            //}


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            try { 


            if (Session["uid"].ToString() == "herasat")
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

                SqlCommand comm = new SqlCommand("select * from tbl_main where id=@p1 and taraf like N'دو طرفه' order by id ", con);

                    comm.Parameters.AddWithValue("@p1", TextBox1.Text);

                 
                    DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);

                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();


                if (dt.Rows.Count > 0)
                {
                    Label1.Text = dt.Rows[0]["step"].ToString();

                }

                Session["step2"] = Label1.Text;
                Session["gozaresh"] = Label2.Text;
            }
            ////////////////////////////////////
            if (Session["flag"].ToString() == "1")
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

                SqlCommand comm = new SqlCommand("select * from tbl_main where id='" + TextBox1.Text + "' and bestar like N'سیم خصوصی'  and shahr like N'" + Label3.Text + "' order by id ", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);

                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();


                if (dt.Rows.Count > 0)
                {
                    Label1.Text = dt.Rows[0]["step"].ToString();

                }

                Session["step2"] = Label1.Text;
                Session["gozaresh"] = Label2.Text;
            }


            /////////////////////
            if ((Session["flag"].ToString() != "1")&&(Session["uid"].ToString() != "herasat"))
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

                SqlCommand comm = new SqlCommand("select * from tbl_main where id='" + TextBox1.Text + "'  order by id ", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);

                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();


                if (dt.Rows.Count > 0)
                {
                    Label1.Text = dt.Rows[0]["step"].ToString();

                }

                Session["step2"] = Label1.Text;
                Session["gozaresh"] = Label2.Text;
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

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {


        }
    }
}