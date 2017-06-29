using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class LoginTest : System.Web.UI.Page
    {
        private static string name = "";
       

        private string RemoveSpace(string s)
        {
            if (s != "")
            {
               return s.Replace(" ", string.Empty);
                //string trim = s.Substring(s.IndexOf('~') + 2);
                //int index = 0;
                //foreach (Char c in trim)
                //{
                //    if (Char.IsUpper(c) && index > 2) break;
                //    index++;

                //}

                //return trim.Insert(index, " ").Substring(0, trim.LastIndexOf(".") + 1);
            }
            else
                return "";
        }

        static string UppercaseWords(string value)
        {
            value = value.ToLower(); // first make all small to remove mid word capitals.  
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }


        HttpRequest _httpRequest = HttpContext.Current.Request;
        protected void Page_Load(object sender, EventArgs e)
        {



            //if (TextBox1.Text != "")
            //{

            //    name = TextBox1.Text;
            //    name = RemoveSpace(UppercaseWords(name));
            //}
            //else
            //    return;

            //if (Request.Cookies.Keys.Count == 0)
            //{
            //     if (TextBox1.Text == "")
            if (!Page.IsPostBack)
            {
               
                if (_httpRequest.Browser.IsMobileDevice) // only use cookies if mobile device.  This way if HUC enters from desktop, the name TB is blank
                {

                    TextBox1.Text = string.Empty;
                    TextBox2.Text = string.Empty;
                    TextBox1.BackColor = default(System.Drawing.Color);
                    TextBox2.BackColor = default(System.Drawing.Color);
                    if (Request.Cookies["user"] != null)
                    {
                        TextBox1.Text = Server.HtmlEncode(Request.Cookies["user"].Value);

                        name = UppercaseWords(TextBox1.Text);
                        //   Response.Cookies["user"].Value = RemoveSpace(UppercaseWords(TextBox1.Text));
                        //     Response.Cookies["user"].Value = name;
                        //     Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);

                        //   var propval = prop.GetValue(ob);
                        var type = typeof(Global);

                        var prop = type.GetProperty(RemoveSpace(name));
                        if (prop != null)
                        {
                            Response.Cookies["user"].Value = name;
                            //  Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
                            Response.Cookies["user"].Expires = DateTime.MaxValue;
                            TextBox1.BackColor = System.Drawing.Color.Lime;
                            TextBox1.Text = Response.Cookies["user"].Value;
                            Button2.Enabled = false;
                        }
                        else
                            TextBox1.Text = "Invalid User";






                    }
                    else
                        return;

                }
                //  TextBox1.Text = Server.HtmlEncode(Request.Cookies["user"].Value);
            }
            //if (TextBox1.Text == Server.HtmlEncode(Request.Cookies["user"].Value))
            //    name = TextBox1.Text;
            //else
            //    return;
               // TextBox1.Text = name;
                //if (TextBox1.Text != "")
                //{
                //    name = RemoveSpace(UppercaseWords(TextBox1.Text));
                //    Response.Cookies["user"].Value = name;
                //    Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
                //}
          



        
            //   Response.Cookies["user"].Value = "test";
            //Response.Write("<br> no cookies</br>");
            //HttpCookie cookie = new HttpCookie("user", "test");
            //Response.Cookies.Add(cookie);
            //    }
            //else
            //{
            //    if (Request.Cookies.Keys.Count == 1)
            //        Response.Write("<h2>there is one cookie</h2>");
            //    else
            //    {
            //        Response.Write("<h2>there are " + Request.Cookies.Keys.Count + " cookies</h2>");
            //        Response.Write("<h2>there are " + Request.Cookies.ToString() + " cookies</h2>");
            //    }
            //}

        }

        /// <summary>
        /// Returns the input string with the first character converted to uppercase, or mutates any nulls passed into string.Empty
        /// </summary>
       

        protected void Button1_Click(object sender, EventArgs e) // submit ETA
        {



           

            //HttpCookie aCookie = new HttpCookie("user");
            //aCookie.Value = TextBox1.Text;
            //aCookie.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(aCookie);
            //Response.Cookies["user"].Value = name;
            //Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);

            //var ob = new Global();
            //var typ = typeof(Global);
            //var f = typ.GetField(name);
            //var prop = typ.GetProperty(name);
            //   var val = f.GetValue(ob);

            //   var propval = prop.GetValue(ob);
            var type = typeof(Global);
            //   var field = type.GetField(name);
            var prop = type.GetProperty(RemoveSpace(name));
            string NameStatus = RemoveSpace(name) + "Status";
            var status = type.GetProperty(NameStatus);
            if (status.GetValue(null).ToString() == "MD")
            Global.MDrespond++;
            if (status.GetValue(null).ToString() == "PA")
                Global.PArespond++;
      //      Global.KevinSipprellStatus = "Enroute";


            int minutes = Convert.ToInt16(TextBox2.Text);
            DateTime time = DateTime.Now;
            TimeSpan eta = new TimeSpan(0, minutes, 0);
            //   Global.KevinSipprell = time.Add(eta);
           prop.SetValue(null, time.Add(eta));
            status.SetValue(null, "Enroute");


            TextBox2.BackColor = System.Drawing.Color.Lime;
            string responded = name + " Responded: " + TextBox2.Text + " min ETA at " + DateTime.Now.ToString();
            Log.Logstring += responded + "\n";

            //// test new Provider class
            //Provider p = new Provider();
            ////   p.Name = RemoveSpace(name);
            //p.Name = name;
            //p.Eta = time.Add(eta);
            //p.Status = "Enroute";

            //    SetStatus();

            for (int i = 0; i < Provider.providers.Count(); i++)
                if (Provider.providers[i].Name == name)
                {
                    Provider.providers[i].Status = "Enroute";
                    Provider.providers[i].Eta = time.Add(eta);
                }

            if (!_httpRequest.Browser.IsMobileDevice)
                Response.Redirect("~/index.aspx");  // redirect back to index for HUC ETA entry.  
            else
                Response.Redirect("~/success.aspx");

         



        }

        


        private void SetStatus()
        {
            string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ksipp_000\Documents\Visual Studio 2015\Projects\WebApplication1\WebApplication1\App_Data\Providers.mdf"";Integrated Security = True";

            using (var conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    //     cmd.CommandText = "select * from [Table] where Name like '%'+@value+'%'";
                    //          cmd.CommandText = "SELECT * from [Table] WHERE Status = @value";
                    //  cmd.CommandText = "SELECT * from [Table]";
                    //          cmd.Parameters.AddWithValue("@value", target);

                    int minutes = Convert.ToInt16(TextBox2.Text);
                    DateTime time = DateTime.Now;
                    TimeSpan eta = new TimeSpan(0, minutes, 0);

               //     cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute', ETA = '@time', WHERE Name = @value";
                    cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute', ETA = '@time' WHERE Name = @value";
                    cmd.Parameters.AddWithValue("@time", eta.ToString("mm"));
                    cmd.Parameters.AddWithValue("@value", name);

  



                    //     cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute' WHERE Id = 7 ";
                    //      cmd.CommandText = "UPDATE [Table] SET Status = 'Here' WHERE Id = 12 ";
                    //  cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute' WHERE Id = 4 ";
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                 //   GridView1.DataSource = dt;
                 //   GridView1.DataBind();
                    conn.Close();
                    //DataSet ds = new DataSet();
                    //da.Fill(ds, "Name");
                    //GridView1.DataSource = ds;
                    //GridView1.DataBind();
                    //conn.Close();

                }

            }
        }




        protected void TextBox1_TextChanged(object sender, EventArgs e) // enter name here
        {
          
            //name = RemoveSpace(UppercaseWords(TextBox1.Text));
            //Response.Cookies["user"].Value = RemoveSpace(UppercaseWords(TextBox1.Text));
            //Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
        }

        protected void Button2_Click(object sender, EventArgs e) // submit name
        {
            //  name = RemoveSpace(UppercaseWords(TextBox1.Text));
            name = UppercaseWords(TextBox1.Text);
            //   Response.Cookies["user"].Value = RemoveSpace(UppercaseWords(TextBox1.Text));
            Response.Cookies["user"].Value = name;
              Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
          
            //   var propval = prop.GetValue(ob);
            var type = typeof(Global);
         
            var prop = type.GetProperty(RemoveSpace(name));
            if (prop != null)
            {
                Response.Cookies["user"].Value = name;
                Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
                TextBox1.BackColor = System.Drawing.Color.Lime;
                TextBox1.Text = Response.Cookies["user"].Value;
                Button2.Enabled = false;
            }
            else
                TextBox1.Text = "Invalid User";


        }
    }
}