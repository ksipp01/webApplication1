using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class HUC : System.Web.UI.Page
    {

        private string s = "";
        private string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ksipp_000\Documents\Visual Studio 2015\Projects\WebApplication1\WebApplication1\App_Data\Providers.mdf"";Integrated Security = True";
        //  SqlConnection conn = new SqlConnection(@"Server=.\\SQLEXPRESS;Database=Providers");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          //SqlConnection conn = new SqlConnection(connstring);
                String str = "select * from Table where (Name like '%' + @search + '%')";
            //   String str = "SELECT Name FROM Table WHERE Name = " + TextBox32.Text;
            //SqlCommand xp = new SqlCommand(str, conn);
            //xp.Parameters.Add("@search", SqlDbType.NVarChar).Value = TextBox32.Text;
            string target = TextBox32.Text;

            using (var conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
               //     cmd.CommandText = "select * from [Table] where Name like '%'+@value+'%'";
                    cmd.CommandText = "select * from [Table]";
                    cmd.Parameters.AddWithValue("@value", target);

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    conn.Close();
                    //DataSet ds = new DataSet();
                    //da.Fill(ds, "Name");
                    //GridView1.DataSource = ds;
                    //GridView1.DataBind();
                    //conn.Close();

                }

            }

            //conn.Open();
            //xp.ExecuteNonQuery();



        }

    }
}