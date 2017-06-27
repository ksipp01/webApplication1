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

        // private string s = "";
        private string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ksipp_000\Documents\Visual Studio 2015\Projects\WebApplication1\WebApplication1\App_Data\Providers.mdf"";Integrated Security = True";
        //  SqlConnection conn = new SqlConnection(@"Server=.\\SQLEXPRESS;Database=Providers");

        private void CancelUnexpectedRePost()
        {
            string clientCode = _repostcheckcode.Value;

            //Get Server Code from session (Or Empty if null)
            string serverCode = Session["_repostcheckcode"] as string ?? "";

            if (!IsPostBack || clientCode.Equals(serverCode))
            {
                //Codes are equals - The action was initiated by the user
                //Save new code (Can use simple counter instead Guid)
                string code = Guid.NewGuid().ToString();
                _repostcheckcode.Value = code;
                Session["_repostcheckcode"] = code;
            }
            else
            {
                //Unexpected action - caused by F5 (Refresh) button
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }



        private void DisplayEnroute()
        {

            using (var conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from [Table] WHERE Status = 'Enroute'";
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    conn.Close();

                }

            }
        }


        private void DisplayHere()
        {

            using (var conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from [Table] WHERE Status = 'Here'";
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                    conn.Close();

                }

            }
        }

        private void DisplayDone()
        {

            using (var conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from [Table] WHERE Status = 'Done'";
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView3.DataSource = dt;
                    GridView3.DataBind();
                    conn.Close();

                }

            }
        }

        private Boolean IsPageRefresh = false;

        HttpRequest _httpRequest = HttpContext.Current.Request;

        protected void Page_Load(object sender, EventArgs e)
        {

            CancelUnexpectedRePost();





            if (!IsPostBack)
            {
                ViewState["postids"] = System.Guid.NewGuid().ToString();
                Session["postid"] = ViewState["postids"].ToString();
            }
            else
            {
                if (ViewState["postids"].ToString() != Session["postid"].ToString())
                {
                    IsPageRefresh = true;
                }
                Session["postid"] = System.Guid.NewGuid().ToString();
                ViewState["postids"] = Session["postid"].ToString();
            }
            if (!IsPageRefresh) // prevent page refresh from tiggering again
            {


                DisplayEnroute();
                DisplayDone();
                DisplayHere();
            }
        }
        protected void RowDataBound(Object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // if (e.Row.RowIndex == 0)     // This is row no.1
                if (e.Row.Cells[3].Text == "Enroute")
                    e.Row.Cells[3].BackColor = System.Drawing.Color.Lime;

                //   if (e.Row.RowIndex == 1)     // This is row no.2
                if (e.Row.Cells[3].Text == "Here")
                    e.Row.Cells[3].BackColor = System.Drawing.Color.Yellow;

                if (e.Row.Cells[3].Text == "Done")
                    e.Row.Cells[3].BackColor = System.Drawing.Color.Red;
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            //     //SqlConnection conn = new SqlConnection(connstring);
            String str = "select * from Table where (Name like '%' + @search + '%')";
            //   String str = "SELECT Name FROM Table WHERE Name = " + TextBox32.Text;
            //SqlCommand xp = new SqlCommand(str, conn);
            //xp.Parameters.Add("@search", SqlDbType.NVarChar).Value = TextBox32.Text;

            using (var conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    //     cmd.CommandText = "select * from [Table] where Name like '%'+@value+'%'";
                    //          cmd.CommandText = "SELECT * from [Table] WHERE Status = @value";
                    cmd.CommandText = "SELECT * from [Table]";
                    //          cmd.Parameters.AddWithValue("@value", target);

                    //           cmd.CommandText = "UPDATE [Table] SET Status = 'Here' WHERE Name = 'Kevin Sipprell' ";
                    //     cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute' WHERE Id = 7 ";
                    //      cmd.CommandText = "UPDATE [Table] SET Status = 'Here' WHERE Id = 12 ";
                    //  cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute' WHERE Id = 4 ";
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "UPDATE [Table] SET Status = ''";
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //GridView1.DataSource = dt;
                    //GridView1.DataBind();
                    conn.Close();

                }
            }
        }
    }
}