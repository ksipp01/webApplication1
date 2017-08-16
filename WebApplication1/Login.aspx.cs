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
            TextBox1.BackColor = default(System.Drawing.Color);
            //if (TextBox1.BackColor == System.Drawing.Color.Lime)
            //    ListBox1.SelectedIndex = -1;
      

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

           

                if (ListBox1.Items.Count == 0)
                    for (int i = 0; i < Provider.providers.Count(); i++)
                        if (Provider.providers[i] != null)
                        {
                            ListBox1.Items.Add(Provider.providers[i].Name);
                        }
                //if (ListBox1.SelectedIndex != -1)
                //    TextBox1.Text = ListBox1.SelectedItem.Text;



                if (_httpRequest.Browser.IsMobileDevice) // only use cookies if mobile device.  This way if HUC enters from desktop, the name TB is blank
                {
                  //  ListBox1.Enabled = false;
                    TextBox1.Text = string.Empty;
                    TextBox2.Text = string.Empty;
                    TextBox1.BackColor = default(System.Drawing.Color);
                    TextBox2.BackColor = default(System.Drawing.Color);
                    if (Request.Cookies["user"] != null)
                    {
                        if (Request.Cookies["user"].Value != "")
                        {
                            ListBox1.Visible = false;
                            TextBox1.Text = Server.HtmlEncode(Request.Cookies["user"].Value);
                            //  TextBox1.Text = cookie["user"];
                            name = UppercaseWords(TextBox1.Text);


                            for (int i = 0; i < Provider.providers.Count(); i++)
                                if (Provider.providers[i] != null)
                                {
                                    if (Provider.providers[i].Name == name)
                                    {
                                        TextBox1.BackColor = System.Drawing.Color.Lime;
                                        Button2.Enabled = false;
                                    }
                                }


                            //   Response.Cookies["user"].Value = RemoveSpace(UppercaseWords(TextBox1.Text));
                            //     Response.Cookies["user"].Value = name;
                            //     Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);

                            //   var propval = prop.GetValue(ob);



                            //var type = typeof(Global);

                            //var prop = type.GetProperty(RemoveSpace(name));
                            //if (prop != null)
                            //{
                            //    Response.Cookies["user"].Value = name;
                            //    //  Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
                            //    Response.Cookies["user"].Expires = DateTime.MaxValue;
                            //    TextBox1.BackColor = System.Drawing.Color.Lime;
                            //    TextBox1.Text = Response.Cookies["user"].Value;
                            //    Button2.Enabled = false;
                            //}
                            //else
                            //    TextBox1.Text = "Invalid User";






                        }
                        else
                        {
                            Label lbl = new Label();
                            lbl.Style[HtmlTextWriterStyle.FontSize] = "60%";
                            lbl.Style[HtmlTextWriterStyle.MarginTop] = "5px";
                            lbl.Text = "First Time use: " + "<br>" + "-Select your name from list above" + "<br>" + "-Ensure correct selection then click \"Submit\"" + "<br>" + "-Your name will auto-fill from now on";
                            PlaceHolder1.Controls.Add(lbl);
                            return;
                        }
                    }
                    else
                    {
                        Label lbl = new Label();
                        lbl.Style[HtmlTextWriterStyle.FontSize] = "60%";
                        lbl.Style[HtmlTextWriterStyle.MarginTop] = "5px";
                        lbl.Text = "First Time use: " + "<br>" + "-Select your name from list above" + "<br>" + "-Ensure correct selection then click \"Submit\"" + "<br>" + "-Your name will auto-fill from now on";
                        PlaceHolder1.Controls.Add(lbl);
                        return;
                    }
                

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
           //     Response.Cookies["user"].Expires = DateTime.Now.AddDays(1000);
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
            int minutes = Convert.ToInt16(TextBox2.Text);
            DateTime time = DateTime.Now;
            TimeSpan eta = new TimeSpan(0, minutes, 0);


            for (int i = 0; i < Provider.providers.Count(); i++)
                if (Provider.providers[i] != null)
                {
                    if (Provider.providers[i].Name == name)
                    {
                        Provider.providers[i].Status = "Enroute";
                        Provider.providers[i].Eta = time.Add(eta);
                        Log.Logstring += Provider.providers[i].Name + ":" + TextBox2.Text + " min ETA - " + DateTime.Now.ToString("HHmm") + "\r\n";
                        Log.LogFile(Provider.providers[i].Name + ":" + TextBox2.Text + " min ETA - " + DateTime.Now.ToString("HHmm"));
                        if (Provider.providers[i].Type == "MD")
                            Provider.MDrespond++;
                        else
                            Provider.PArespond++;
                    }
                }
            TextBox2.BackColor = System.Drawing.Color.Lime;
            //else
            //    return;

            if (!_httpRequest.Browser.IsMobileDevice)
                Response.Redirect("~/index.aspx");  // redirect back to index for HUC ETA entry.  
            else
                Response.Redirect("~/success.aspx");


            


        }




        //private void SetStatus()
        //{
        //    string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ksipp_000\Documents\Visual Studio 2015\Projects\WebApplication1\WebApplication1\App_Data\Providers.mdf"";Integrated Security = True";

        //    using (var conn = new SqlConnection(connstring))
        //    {
        //        conn.Open();
        //        using (var cmd = conn.CreateCommand())
        //        {
        //            //     cmd.CommandText = "select * from [Table] where Name like '%'+@value+'%'";
        //            //          cmd.CommandText = "SELECT * from [Table] WHERE Status = @value";
        //            //  cmd.CommandText = "SELECT * from [Table]";
        //            //          cmd.Parameters.AddWithValue("@value", target);

        //            int minutes = Convert.ToInt16(TextBox2.Text);
        //            DateTime time = DateTime.Now;
        //            TimeSpan eta = new TimeSpan(0, minutes, 0);

        //       //     cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute', ETA = '@time', WHERE Name = @value";
        //            cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute', ETA = '@time' WHERE Name = @value";
        //            cmd.Parameters.AddWithValue("@time", eta.ToString("mm"));
        //            cmd.Parameters.AddWithValue("@value", name);





        //            //     cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute' WHERE Id = 7 ";
        //            //      cmd.CommandText = "UPDATE [Table] SET Status = 'Here' WHERE Id = 12 ";
        //            //  cmd.CommandText = "UPDATE [Table] SET Status = 'Enroute' WHERE Id = 4 ";
        //            SqlDataAdapter da = new SqlDataAdapter();
        //            da.SelectCommand = cmd;
        //            DataTable dt = new DataTable();
        //            da.Fill(dt);
        //         //   GridView1.DataSource = dt;
        //         //   GridView1.DataBind();
        //            conn.Close();
        //            //DataSet ds = new DataSet();
        //            //da.Fill(ds, "Name");
        //            //GridView1.DataSource = ds;
        //            //GridView1.DataBind();
        //            //conn.Close();

        //        }

        //    }
        //}




        protected void TextBox1_TextChanged(object sender, EventArgs e) // enter name here
        {

            //name = RemoveSpace(UppercaseWords(TextBox1.Text));
            //Response.Cookies["user"].Value = RemoveSpace(UppercaseWords(TextBox1.Text));
            //Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
        }

        protected void Button2_Click(object sender, EventArgs e) // submit name
        {
            name = UppercaseWords(TextBox1.Text);

            //

            if (ListBox1.SelectedIndex != -1)
                TextBox1.Text = ListBox1.SelectedItem.Text;
            for (int i = 0; i < Provider.providers.Count(); i++)
                if (Provider.providers[i] != null)
                {
                    if (Provider.providers[i].Name == name)
                    {
                        TextBox1.BackColor = System.Drawing.Color.Lime;
                        TextBox1.Text = Provider.providers[i].Name;

                    }
                    //else
                    //{
                    //    TextBox1.Text = "Invalid User";
                    //    return;
                    //}
                }
            if (TextBox1.BackColor != System.Drawing.Color.Lime)
            {
                TextBox1.Text = "Invalid User";
                return;
            }

            //    TextBox1.Text = Response.Cookies["user"].Value;
            //       Button2.Enabled = false;
            name = UppercaseWords(TextBox1.Text);
            //   Response.Cookies["user"].Value = RemoveSpace(UppercaseWords(TextBox1.Text));


          //  remd 8-10-17
            Response.Cookies["user"].Value = name;
            Response.Cookies["user"].Expires = DateTime.Now.AddYears(10);
         

            //   var propval = prop.GetValue(ob);
            //var type = typeof(Global);

            //var prop = type.GetProperty(RemoveSpace(name));
            //if (prop != null)
            //{
            //    Response.Cookies["user"].Value = name;
            //    Response.Cookies["user"].Expires = DateTime.Now.AddDays(1);
            //    TextBox1.BackColor = System.Drawing.Color.Lime;

            //}



        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            TextBox1.Text = ListBox1.SelectedItem.Text;
            Label lbl = new Label();
            lbl.Style[HtmlTextWriterStyle.FontSize] = "80%";
            lbl.Style[HtmlTextWriterStyle.MarginTop] = "5px";
            lbl.Text = "First Time use: Select your name from list above" + "<br>" + "Ensure correct selection then click \"Submit\"" + "<br>" + "Your name will auto-populate with subsequent use";
            PlaceHolder1.Controls.Add(lbl);
        }

        //protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    TextBox1.Text = ListBox1.SelectedItem.Text;
        //    //    Response.Redirect("~/login.aspx");
        //}
    }
}