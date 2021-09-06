using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;

using System.Data;
using System.Data.SqlClient;

using System.IO;

namespace Webtamrin1
{
    public partial class kartabl4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            try {
                TextBox4.Attributes["onclick"] = "PersianDatePicker.Show(this,'" + "1399/01/01" + "');";
                TextBox8.Attributes["onclick"] = "PersianDatePicker.Show(this,'" + "1399/01/01" + "');";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

            if (IsPostBack != true)


            { ///////////////////////////////////////jahate namayeshe etelaate vared shodeh 
                SqlCommand comm2 = new SqlCommand("select * from tbl_main where id=@p1", con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(comm2);
                comm2.Parameters.AddWithValue("p1", Request.QueryString["id"].ToString());

                da2.Fill(dt2);


                if (dt2.Rows.Count > 0)
                {
                    TextBox1.Text = dt2.Rows[0]["room"].ToString();
                    TextBox3.Text = dt2.Rows[0]["name"].ToString();
                    TextBox4.Text = dt2.Rows[0]["tarikh1"].ToString();
                    TextBox5.Text = dt2.Rows[0]["tarikh2"].ToString();
                    TextBox6.Text = dt2.Rows[0]["tel"].ToString();
                    TextBox7.Text = dt2.Rows[0]["tozih"].ToString();
                    TextBox8.Text = dt2.Rows[0]["tarikh3"].ToString();
                    TextBox9.Text = dt2.Rows[0]["tamirkar"].ToString();
                    TextBox10.Text = dt2.Rows[0]["service"].ToString();
                    TextBox11.Text = dt2.Rows[0]["cooler"].ToString();
                    TextBox12.Text = dt2.Rows[0]["shenase"].ToString();
                    Label1.Text = dt2.Rows[0]["id"].ToString();
                }
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
            con.Open();

          //  SqlCommand comm2 = new SqlCommand("update tbl_main set   room=N'" + TextBox1.Text + "',name=N'" + TextBox3.Text + "',tarikh1=N'" + TextBox4.Text + "',tarikh2=N'" + TextBox5.Text + "',tel=N'" + TextBox6.Text + "',tozih=N'" + TextBox7.Text + "',tarikh3=N'" + TextBox8.Text + "',tamirkar=N'" + TextBox9.Text + "' ,service=N'" + TextBox10.Text + "',cooler=N'" + TextBox11.Text + "' ,shenase=N'" + TextBox12.Text + "' where id='" + Label1.Text + "'", con);
                SqlCommand comm2 = new SqlCommand("update tbl_main set   room=@p1,name=@p3,tarikh1=@p4,tarikh2=@p5,tel=@p6,tozih=@p7,tarikh3=@p8,tamirkar=@p9 ,service=@p10,cooler=@p11 ,shenase=@p12 where id=@p13", con);
                comm2.Parameters.AddWithValue("@P1", TextBox1.Text);
                comm2.Parameters.AddWithValue("@P3", TextBox3.Text);
                comm2.Parameters.AddWithValue("@P4", TextBox4.Text);
                comm2.Parameters.AddWithValue("@P5", TextBox5.Text);
                comm2.Parameters.AddWithValue("@P6", TextBox6.Text);
                comm2.Parameters.AddWithValue("@P7", TextBox7.Text);
                comm2.Parameters.AddWithValue("@P8", TextBox8.Text);
                comm2.Parameters.AddWithValue("@P9", TextBox9.Text);
                comm2.Parameters.AddWithValue("@P10", TextBox10.Text);
                comm2.Parameters.AddWithValue("@P11", TextBox11.Text);
                comm2.Parameters.AddWithValue("@P12", TextBox12.Text);
                comm2.Parameters.AddWithValue("@P13", Label1.Text);
                comm2.ExecuteNonQuery();
                con.Close();
        }
            catch (Exception exception)
            {
            }

}

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
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
           
        }
    }
}