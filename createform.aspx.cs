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

namespace WebApplication1
{
    public partial class createform : System.Web.UI.Page
    {
        private RequestHandler requestHandler;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Attributes["onclick"] = "PersianDatePicker.Show(this,'" + "1399/01/01" + "');";
            TextBox13.Attributes["onclick"] = "PersianDatePicker.Show(this,'" + "1399/01/01" + "');";

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
            //String proxyHost = ConfigurationSettings.AppSettings["proxy_host"];

            //requestHandler = new RequestHandler();



            //try
            //{
            //    String enqueueUrl = UrlGenerator.generateEnqueueUrl(
            //"tcihormozgan_4544",
            //"utCIMOLRpByIPHzg",
            //"magfa",
            //"30004544",
            //"09177613059",
            //"testttt",
            //null,
            //null,
            //null
            //    );
            //    String messageId = requestHandler.get(enqueueUrl);
            //    int returnValue = int.Parse(messageId);


            //}
            //catch (Exception exception)
            //{
            //}
            //finally
            //{

            //}

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            Response.Redirect("WebForm13.aspx");
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

        protected void Button2_Click(object sender, EventArgs e)
        {
           // try { 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server150"].ConnectionString);

            if ((TextBox1.Text != "") & (TextBox2.Text != "") & (TextBox9.Text != ""))
            {

                SqlCommand comm = new SqlCommand("INSERT INTO tbl_main (name,tarikh1,tarikh2,dastgah,service,shenase,tel,room,sakh,tozih,tarikh3,tamirkar,cooler) VALUES (@name,@tarikh1,@tarikh2,@dastgah,@service,@shenase,@tel,@room,@sakh,@tozih,@tarikh3,@tamirkar,@cooler)", con);



                comm.Parameters.AddWithValue("@name", TextBox1.Text);
                comm.Parameters.AddWithValue("@tarikh1", TextBox2.Text);
                comm.Parameters.AddWithValue("@tarikh2", TextBox3.Text);
              //  comm.Parameters.AddWithValue("@bestar", DropDownList1.Text);
                comm.Parameters.AddWithValue("@dastgah", DropDownList5.Text);
              //  comm.Parameters.AddWithValue("@noe", DropDownList3.Text);
                comm.Parameters.AddWithValue("@service", TextBox11.Text);
                comm.Parameters.AddWithValue("@shenase", TextBox9.Text);
                comm.Parameters.AddWithValue("@tel", TextBox10.Text);
                comm.Parameters.AddWithValue("@room", TextBox7.Text);
                comm.Parameters.AddWithValue("@sakh", TextBox6.Text);
             //   comm.Parameters.AddWithValue("@f60", DropDownList6.Text);
                comm.Parameters.AddWithValue("@tozih", TextBox5.Text);
                comm.Parameters.AddWithValue("@cooler", TextBox12.Text);
                    comm.Parameters.AddWithValue("@tarikh3", TextBox13.Text);
                    comm.Parameters.AddWithValue("@tamirkar", TextBox14.Text);
                

                    con.Open();
                comm.ExecuteNonQuery();
                con.Close();
                //  Response.Redirect("kartabl.aspx");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox9.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                    TextBox13.Text = "";
                    TextBox14.Text = "";
             

                }


       // }
          //  catch (Exception exception)
          //  {
          //  }


}
    }
}