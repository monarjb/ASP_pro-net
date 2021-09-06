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
    public partial class kartabl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
                Response.Redirect("login.aspx");
            if (IsPostBack != true)
            {

                Session["gozaresh"] = "0";

                Label1.Text = Session["uid"].ToString();
               
                Label3.Text = Session["shahr"].ToString();
                SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
                SqlCommand comm2 = new SqlCommand("select *  from tbl_user where  usr='"+Label1.Text+"'" , con2);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(comm2);


                da2.Fill(dt2);
                DropDownList1.DataSource = dt2;
                DropDownList1.DataValueField = "step";
                DropDownList1.DataTextField = "step";
                DropDownList1.DataBind();
                // Label1.Text = Session["uid"].ToString();

                Label2.Text = DropDownList1.SelectedItem.Text;
                Session["step2"] = Label2.Text;
                Label4.Text = dt2.Rows[0]["flag"].ToString();
                if (dt2.Rows[0]["flag"].ToString() == "1")
                {
                    SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
                    SqlCommand comm3 = new SqlCommand("select * from tbl_main    where  shahr like N'%"+Label3.Text+"%'  and step like N'" + Label2.Text + "'", con3);
               //   Response.Write(comm3.CommandText);
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da3 = new SqlDataAdapter(comm3);

                    da3.Fill(dt3);

                    GridView1.DataSource = dt3;
                    GridView1.DataBind();

                }
                else
                {


                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

                    SqlCommand comm = new SqlCommand("select * from tbl_main    where   step like N'" + DropDownList1.Text + "'", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(comm);

                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
            }


            if (Session["uid"].ToString() == "admin") {


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

                SqlCommand comm = new SqlCommand("select * from tbl_main   order by id ", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);

                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();


            }



            ////////////////////////////////////



        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
                Label2.Text = DropDownList1.SelectedItem.Text;
            Session["step2"] = Label2.Text;
            if (Label4.Text == "1")
                {
                    SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
                    SqlCommand comm3 = new SqlCommand("select * from tbl_main    where  shahr like N'%" + Label3.Text + "%'  and step like N'" +DropDownList1.Text + "'", con3);
                     // Response.Write(comm3.CommandText);
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da3 = new SqlDataAdapter(comm3);

                    da3.Fill(dt3);

                    GridView1.DataSource = dt3;
                    GridView1.DataBind();

                }
                else
                {


                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

                    SqlCommand comm = new SqlCommand("select * from tbl_main    where   step like N'" + DropDownList1.Text + "'", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(comm);

                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                }
          // }


            if (Session["uid"].ToString() == "admin")
            {


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

                SqlCommand comm = new SqlCommand("select * from tbl_main   order by id ", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);

                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();


            }




        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {


            
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["uid"].ToString() == "admin")
            {

                Response.Redirect("createform.aspx");
            }
            else {

                Response.Redirect("webform13.aspx");

            }
        }
    }
}