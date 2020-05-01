using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Sannibhhhh
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextSearch(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["con"].ToString());
            con.Open();
            SqlCommand sqlcom = new SqlCommand();
            string query = "select * from Table1 where S_ID  like '%' +  @S_ID + '%' ";
            sqlcom.CommandText = query;
            sqlcom.Connection = con;
            sqlcom.Parameters.AddWithValue("S_ID", SearchText.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["con"].ToString());
            con.Open();
            SqlCommand sqlcom = new SqlCommand();
            string query = "Delete from Table1 where S_ID  like '%' +  @S_ID + '%' ";
            sqlcom.CommandText = query;
            sqlcom.Connection = con;
            sqlcom.Parameters.AddWithValue("S_ID", SearchText.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }
}