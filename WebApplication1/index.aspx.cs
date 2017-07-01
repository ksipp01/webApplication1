using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class TestProviderClass : System.Web.UI.Page
    {
        private bool isMobile = false;

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
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpRequest _httpRequest = HttpContext.Current.Request;
            if (_httpRequest.Browser.IsMobileDevice)
            {
                isMobile = true;
               // HttpContext.Current.Response.Redirect("~/login.aspx");
              
            }



            TextBox67.Text = Provider.Mdhere.ToString();
            TextBox68.Text = Provider.MDrespond.ToString();
            TextBox69.Text = Provider.PAhere.ToString();
            TextBox70.Text =Provider.PArespond.ToString();
            //Label2.BackColor = System.Drawing.Color.Lime;
            //Label3.BackColor = System.Drawing.Color.Yellow;
            //Label4.BackColor = System.Drawing.Color.Red;
         //   if (TextBox67.Text == "0")
                TextBox67.BackColor = System.Drawing.Color.Yellow;
            //    else
            //        TextBox67.BackColor = System.Drawing.Color.Lime;
            //    if (TextBox68.Text == "0")
            TextBox68.BackColor = System.Drawing.Color.Lime;
         //   else
               // TextBox68.BackColor = System.Drawing.Color.Lime;
        //    if (TextBox69.Text == "0")
                TextBox69.BackColor = System.Drawing.Color.Yellow;
            //  else
            //  TextBox69.BackColor = System.Drawing.Color.Lime;
            //    if (TextBox70.Text == "0")
            TextBox70.BackColor = System.Drawing.Color.Lime;
          //  else
           //     TextBox70.BackColor = System.Drawing.Color.Lime;

            CancelUnexpectedRePost();
            FindStatus();
        
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    //  TextBox1.Text = Provider.providers[4].Name + " " + Provider.providers[4].Type;
        //    FindStatus();
       // }
        Button btn;
        private void FindStatus()
        {
            for(int i = 0; i < Provider.providers.Count(); i++)
            {
                if (Provider.providers[i] != null)
                if (Provider.providers[i].Status == "Enroute")
                {
                    Label lbl = new Label();
                    lbl.Width = 350;
                        lbl.Font.Size = 16;
                        lbl.BackColor = System.Drawing.Color.Lime;
                    btn = new Button() { ID = Provider.providers[i].Name.ToString() + " _btn", Text = "Here" };
                        btn.Font.Size = 14;
                        string btnName = Provider.providers[i].Name;
                    // btn.Click += new EventHandler(Dymanic_Method);
                    btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };
                    TimeSpan diff = (Provider.providers[i].Eta.Subtract(DateTime.Now));
                    double m = diff.TotalMinutes;
                    m = Math.Round(m, MidpointRounding.AwayFromZero);
                   
                    //    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                    lbl.Text = Provider.providers[i].Name + " - Enroute" + " ETA: " + m.ToString();
                    
                        if (Provider.providers[i].Type == "MD")
                        {
                            PlaceHolder1.Controls.Add(lbl);
                            if (!isMobile)
                            PlaceHolder1.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder1.Controls.Add(linebreak);
                        }
                        else
                        {
                            PlaceHolder2.Controls.Add(lbl);
                            if (!isMobile)
                                PlaceHolder2.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder2.Controls.Add(linebreak);
                        }
                   
                }
                if (Provider.providers[i] != null)
                    if (Provider.providers[i].Status == "Here")
                {
                    Label lbl = new Label();
                    lbl.Width = 350;
                        lbl.Font.Size = 16;
                        lbl.BackColor = System.Drawing.Color.Yellow;
                    string btnName = Provider.providers[i].Name;
                    btn = new Button() { ID = btnName + " _btn", Text = "Done" };
                        btn.Font.Size = 14;
                        // btn.Click += new EventHandler(Dymanic_Method);
                        btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };



                    //TimeSpan diff = (Provider.providers[i].Eta.Subtract(DateTime.Now));
                    //double m = diff.TotalMinutes;
                    //m = Math.Round(m, MidpointRounding.AwayFromZero);


                    //    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                    lbl.Text = Provider.providers[i].Name + " - Here" + " at " + Provider.providers[i].Eta.ToString("HHmm");
                        if (Provider.providers[i].Type == "MD")
                        {
                            PlaceHolder3.Controls.Add(lbl);
                            if (!isMobile)
                                PlaceHolder3.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder3.Controls.Add(linebreak);
                        }
                        else
                        {
                            PlaceHolder6.Controls.Add(lbl);
                            if (!isMobile)
                                PlaceHolder6.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder6.Controls.Add(linebreak);
                        }


                }
                if (Provider.providers[i] != null)
                    if (Provider.providers[i].Status == "Done")
                    {
                        Label lbl = new Label();
                        lbl.Width = 350;
                        lbl.Font.Size = 16;
                        lbl.BackColor = System.Drawing.Color.Red;
                        string btnName = Provider.providers[i].Name;
                        //btn = new Button() { ID = btnName + " _btn", Text = "Done" };
                        //// btn.Click += new EventHandler(Dymanic_Method);
                        //btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };



                        //TimeSpan diff = (Provider.providers[i].Eta.Subtract(DateTime.Now));
                        //double m = diff.TotalMinutes;
                        //m = Math.Round(m, MidpointRounding.AwayFromZero);


                        //    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                        //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                        lbl.Text = Provider.providers[i].Name + " - Done" + " at " + Provider.providers[i].Eta.ToString("HHmm");
                        if (Provider.providers[i].Type == "MD")
                        {
                            PlaceHolder7.Controls.Add(lbl);
                            //     PlaceHolder1.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder7.Controls.Add(linebreak);
                        }
                        else
                        {
                            PlaceHolder8.Controls.Add(lbl);
                            //     PlaceHolder1.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder8.Controls.Add(linebreak);
                        }
                    }
                if (Provider.providers[i] != null)
                    if (Provider.providers[i].Status == null) // List MD that have not responded
                {
                    Label lbl = new Label();
                    lbl.Width = 350;
                        lbl.Font.Size = 16;

                        if (Provider.providers[i].Type == "MD")
                        {
                            lbl.Text = Provider.providers[i].Name;
                            PlaceHolder4.Controls.Add(lbl);

                            btn = new Button() { ID = Provider.providers[i].Name.ToString() + " _btn", Text = "Here" };
                            btn.Font.Size = 14;
                            string btnName = Provider.providers[i].Name;
                            // btn.Click += new EventHandler(Dymanic_Method);
                            btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };
                            if (!isMobile)
                                PlaceHolder4.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder4.Controls.Add(linebreak);
                        }


                }
                if (Provider.providers[i] != null) // list PAs that have not responded
                    if (Provider.providers[i].Status == null)
                    {
                        Label lbl = new Label();
                        lbl.Width = 350;
                        lbl.Font.Size = 16;

                        if (Provider.providers[i].Type == "PA")
                        {
                            lbl.Text = Provider.providers[i].Name;
                            PlaceHolder5.Controls.Add(lbl);
                            btn = new Button() { ID = Provider.providers[i].Name.ToString() + " _btn", Text = "Here" };
                            btn.Font.Size = 14;
                            string btnName = Provider.providers[i].Name;
                            // btn.Click += new EventHandler(Dymanic_Method);
                            btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };
                            if (!isMobile)
                                PlaceHolder5.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder5.Controls.Add(linebreak);
                        }

                    }

            }
        }


        protected void Dymanic_Method(object sender, EventArgs e, string name)
        {
            bool justShowedUp = false;
            for (int i = 0; i < Provider.providers.Count(); i++)
            {
                if (Provider.providers[i] != null) // allow for those who don't respond w/ ETA to show up....
                    if (Provider.providers[i].Name == name)
                    {
                        if (Provider.providers[i].Status == null)
                        {
                            Provider.providers[i].Status = "Here";
                            justShowedUp = true;
                            Log.Logstring += Provider.providers[i].Name + ": Arrived - " + DateTime.Now.ToString("HHmm") + "\r\n";
                            if (Provider.providers[i].Type == "MD")
                            {
                                Provider.Mdhere++;
                                Provider.providers[i].Eta = DateTime.Now;
                               
                               
                            }

                            else
                            {
                                Provider.PAhere++;
                                Provider.providers[i].Eta = DateTime.Now;
                              

                            }
                        }
                    }


                        if (Provider.providers[i] != null)
                if (Provider.providers[i].Name == name)
                {
                    if (Provider.providers[i].Status == "Here" && !justShowedUp)
                    {
                        Provider.providers[i].Status = "Done";
                       Log.Logstring += Provider.providers[i].Name + ": Complete - " + DateTime.Now.ToString("HHmm") + "\r\n";
                            if (Provider.providers[i].Type == "MD")
                            Provider.Mdhere--;

                        else
                            Provider.PAhere--;
                    }
                        if (Provider.providers[i] != null)
                        if (Provider.providers[i].Status == "Enroute")
                    {
                        Provider.providers[i].Status = "Here";
                        Log.Logstring += Provider.providers[i].Name + ": Arrived - " + DateTime.Now.ToString("HHmm") + "\r\n";
                          if (Provider.providers[i].Type == "MD")
                        {
                            Provider.MDrespond--;
                            Provider.Mdhere++;
                        }
                        else
                        {
                           Provider.PArespond--;
                            Provider.PAhere++;
                        }
                    }
                        if (Provider.providers[i] != null)
                            Provider.providers[i].Eta = DateTime.Now;
                }
            }
            justShowedUp = false;
            Response.Redirect("~/index.aspx");
        }

        //private void CreateChildControls()
        //{


        //    var type = typeof(Provider);
        //    //   var field = type.GetField(name);
        //    //   Type type = obj.GetType();
        //    PropertyInfo[] properties = type.GetProperties();



        //    //var prop = type.GetProperty(name);


        //    foreach (PropertyInfo property in properties)
        //    {

        //        //  string NameStatus = RemoveSpace(name) + "Status";
        //        //var status = type.GetProperty(nameStatus);
        //        // var name = status.Name;
        //        // var s = status.GetValue(null);
        //        //if (status.GetValue(null).ToString() == "Enroute")
        //        //{
        //        string val = property.Name.ToString();
        //        if (val.Contains("Status"))
        //        {
        //            var status = type.GetProperty(val);
        //            string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
        //            if (status.GetValue(null).ToString() == "Enroute")
        //            {
        //                Label lbl = new Label();
        //                lbl.Width = 200;
        //                lbl.BackColor = System.Drawing.Color.Lime;
        //                //    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
        //                //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
        //                lbl.Text = name + " - Enroute";
        //                PlaceHolder1.Controls.Add(lbl);
        //                LiteralControl linebreak = new LiteralControl("<br>");
        //                PlaceHolder1.Controls.Add(linebreak);

        //            }
        //            //if (status.GetValue(null).ToString() == "Here")
        //            //{
        //            //    Label lbl = new Label();
        //            //    lbl.Width = 200;
        //            //    lbl.BackColor = System.Drawing.Color.Yellow;
        //            //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Arrvied";
        //            //    placeholder.Controls.Add(lbl);
        //            //    LiteralControl linebreak = new LiteralControl("<br>");
        //            //    placeholder.Controls.Add(linebreak);

        //            //}
        //            //if (status.GetValue(null).ToString() == "Done")
        //            //{
        //            //    Label lbl = new Label();
        //            //    lbl.Width = 200;
        //            //    lbl.BackColor = System.Drawing.Color.Red;
        //            //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Done";
        //            //    placeholder.Controls.Add(lbl);
        //            //    LiteralControl linebreak = new LiteralControl("<br>");
        //            //    placeholder.Controls.Add(linebreak);

        //            //}

        //        }
        //    }
        //    foreach (PropertyInfo property in properties)
        //    {

        //        //  string NameStatus = RemoveSpace(name) + "Status";
        //        //var status = type.GetProperty(nameStatus);
        //        // var name = status.Name;
        //        // var s = status.GetValue(null);
        //        //if (status.GetValue(null).ToString() == "Enroute")
        //        //{
        //        string val = property.Name.ToString();
        //        string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
        //        if (val.Contains("Status"))
        //        {
        //            var status = type.GetProperty(val);
        //            //if (status.GetValue(null).ToString() == "Enroute")
        //            //{
        //            //    Label lbl = new Label();
        //            //    lbl.Width = 200;
        //            //    lbl.BackColor = System.Drawing.Color.Lime;
        //            //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
        //            //    placeholder.Controls.Add(lbl);
        //            //    LiteralControl linebreak = new LiteralControl("<br>");
        //            //    placeholder.Controls.Add(linebreak);

        //            //}
        //            if (status.GetValue(null).ToString() == "Here")
        //            {
        //                Label lbl = new Label();
        //                lbl.Width = 200;
        //                lbl.BackColor = System.Drawing.Color.Yellow;
        //                //  lbl.Text = property.Name.ToString().Replace("Status", "") + " - Arrvied";
        //                lbl.Text = name + " - Arrived";
        //                PlaceHolder1.Controls.Add(lbl);
        //                LiteralControl linebreak = new LiteralControl("<br>");
        //                PlaceHolder1.Controls.Add(linebreak);

        //            }
        //            //if (status.GetValue(null).ToString() == "Done")
        //            //{
        //            //    Label lbl = new Label();
        //            //    lbl.Width = 200;
        //            //    lbl.BackColor = System.Drawing.Color.Red;
        //            //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Done";
        //            //    placeholder.Controls.Add(lbl);
        //            //    LiteralControl linebreak = new LiteralControl("<br>");
        //            //    placeholder.Controls.Add(linebreak);

        //            //}

        //        }
        //    }
        //    foreach (PropertyInfo property in properties)
        //    {

        //        //  string NameStatus = RemoveSpace(name) + "Status";
        //        //var status = type.GetProperty(nameStatus);
        //        // var name = status.Name;
        //        // var s = status.GetValue(null);
        //        //if (status.GetValue(null).ToString() == "Enroute")
        //        //{
        //        string val = property.Name.ToString();
        //        string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
        //        if (val.Contains("Status"))
        //        {
        //            var status = type.GetProperty(val);
        //            //if (status.GetValue(null).ToString() == "Enroute")
        //            //{
        //            //    Label lbl = new Label();
        //            //    lbl.Width = 200;
        //            //    lbl.BackColor = System.Drawing.Color.Lime;
        //            //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
        //            //    placeholder.Controls.Add(lbl);
        //            //    LiteralControl linebreak = new LiteralControl("<br>");
        //            //    placeholder.Controls.Add(linebreak);

        //            //}
        //            //if (status.GetValue(null).ToString() == "Here")
        //            //{
        //            //    Label lbl = new Label();
        //            //    lbl.Width = 200;
        //            //    lbl.BackColor = System.Drawing.Color.Yellow;
        //            //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Arrvied";
        //            //    placeholder.Controls.Add(lbl);
        //            //    LiteralControl linebreak = new LiteralControl("<br>");
        //            //    placeholder.Controls.Add(linebreak);

        //            //}
        //            if (status.GetValue(null).ToString() == "Done")
        //            {
        //                Label lbl = new Label();
        //                lbl.Width = 200;
        //                lbl.BackColor = System.Drawing.Color.Red;
        //                //  lbl.Text = property.Name.ToString().Replace("Status", "") + " - Done";
        //                lbl.Text = name + " - Done";
        //                PlaceHolder1.Controls.Add(lbl);
        //                LiteralControl linebreak = new LiteralControl("<br>");
        //                PlaceHolder1.Controls.Add(linebreak);

        //            }

        //        }

        //    }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!isMobile)
            {
                Provider.Reset();
                Response.Redirect("~/index.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!isMobile)
            {
               
                Response.Redirect("~/login.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/log.aspx");
        }
    }
}