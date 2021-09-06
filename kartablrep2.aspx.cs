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
    public partial class kartablrep2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
            TextBox2.Attributes["onclick"] = "PersianDatePicker.Show(this,'" + "1399/01/01" + "');";
            TextBox3.Attributes["onclick"] = "PersianDatePicker.Show(this,'" + "1399/01/01" + "');";
        }
            catch (Exception exception)
            {
            }


}

protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
            //con.Open();


            //if ((TextBox1.Text != "") & (TextBox3.Text != ""))
            //{

            //    SqlCommand comm = new SqlCommand("INSERT INTO tbl_shenase (shenase,name,sakh,room) VALUES (@shenase,@name,@sakh,@room)", con);



            //    comm.Parameters.AddWithValue("@shenase", TextBox1.Text);
            //    comm.Parameters.AddWithValue("@name", DropDownList1.Text);
            //    comm.Parameters.AddWithValue("@sakh", DropDownList2.Text);
            //    comm.Parameters.AddWithValue("@room", TextBox3.Text);

            //    con.Open();
            //    comm.ExecuteNonQuery();
            //    con.Close();
            //    //  Response.Redirect("kartabl.aspx");
            //    TextBox1.Text = "";

            //    TextBox3.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try { 
              SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
                SqlCommand comm3 = new SqlCommand("select * from tbl_main    where  shenase like N'%@P1%' ", con3);
                comm3.Parameters.AddWithValue("@P1", TextBox1.Text);
                //   Response.Write(comm3.CommandText);
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(comm3);

                da3.Fill(dt3);

                GridView1.DataSource = dt3;
                GridView1.DataBind();
        }
            catch (Exception exception)
            {
            }

}

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            Response.Redirect("webform13.aspx");
            }
            catch (Exception exception)
            {
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            Response.Redirect("login.aspx");
        }
            catch (Exception exception)
            {
            }
}

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
                // SqlCommand comm3 = new SqlCommand("select * from tbl_main    where  SUBSTRING(tarikh1,1,2)+SUBSTRING(tarikh1,4,2)+SUBSTRING(tarikh1,7,2) between '"+TextBox2.Text+ "' and '" + TextBox3.Text + "' and shenase like N'%" + TextBox1.Text + "%'  ", con3);
                //   Response.Write(comm3.CommandText);

                SqlCommand comm3 = new SqlCommand("select * from tbl_main    where  SUBSTRING(tarikh1,1,2)+SUBSTRING(tarikh1,4,2)+SUBSTRING(tarikh1,7,2) between @p2 and @p3 and shenase like  N'%@P1%'   ", con3);
                comm3.Parameters.AddWithValue("@P1", TextBox1.Text);
                comm3.Parameters.AddWithValue("@P2", TextBox2.Text);
                comm3.Parameters.AddWithValue("@P3", TextBox3.Text);
                DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(comm3);

            da3.Fill(dt3);

            GridView1.DataSource = dt3;
            GridView1.DataBind();
            }
            catch (Exception exception)
            {
            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
            SqlCommand comm3 = new SqlCommand("select * from tbl_main    where  tarikh3='0' ", con3);
            //   Response.Write(comm3.CommandText);
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(comm3);

            da3.Fill(dt3);

            GridView1.DataSource = dt3;
            GridView1.DataBind();
            }
            catch (Exception exception)
            {
            }
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
            SqlCommand comm3 = new SqlCommand("select * from tbl_main   order by id desc", con3);
            //   Response.Write(comm3.CommandText);
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(comm3);

            da3.Fill(dt3);

            GridView1.DataSource = dt3;
            GridView1.DataBind();
        }
            catch (Exception exception)
            {
            }
}
        public SortDirection dir
        {

            get
            {

                if (ViewState["dirState"] == null)
                {

                    ViewState["dirState"] = SortDirection.Ascending;

                }

                return (SortDirection)ViewState["dirState"];

            }

            set
            {

                ViewState["dirState"] = value;

            }



        }
        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            try
            {
                SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
                SqlCommand comm3 = new SqlCommand("select * from tbl_main   order by id desc", con3);
                //   Response.Write(comm3.CommandText);
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(comm3);

                da3.Fill(dt3);

                GridView1.DataSource = dt3;
                GridView1.DataBind();
           
            /////////////////
            string SortDir = string.Empty;

            if (dir == SortDirection.Ascending)
            {

                dir = SortDirection.Descending;

                SortDir = "Desc";

            }

            else
            {

                dir = SortDirection.Ascending;

                SortDir = "Asc";

            }

            //      SetSortDirection(SortDireaction);
            if (dt3 != null)
            {
                //Sort the data.
                dt3.DefaultView.Sort = e.SortExpression + " " + SortDir;
                GridView1.DataSource = dt3;
                GridView1.DataBind();

            }
        }
            catch (Exception exception)
            {
            }
}

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);
        //    //con.Open();


        //    //if ((TextBox1.Text != "") & (TextBox3.Text != ""))
        //    //{

        //    //    SqlCommand comm = new SqlCommand("INSERT INTO tbl_shenase (shenase,name,sakh,room) VALUES (@shenase,@name,@sakh,@room)", con);



        //    //    comm.Parameters.AddWithValue("@shenase", TextBox1.Text);
        //    //    comm.Parameters.AddWithValue("@name", DropDownList1.Text);
        //    //    comm.Parameters.AddWithValue("@sakh", DropDownList2.Text);
        //    //    comm.Parameters.AddWithValue("@room", TextBox3.Text);

        //    //    con.Open();
        //    //    comm.ExecuteNonQuery();
        //    //    con.Close();
        //    //    //  Response.Redirect("kartabl.aspx");
        //    //    TextBox1.Text = "";

        //    //    TextBox3.Text = "";

    }
}