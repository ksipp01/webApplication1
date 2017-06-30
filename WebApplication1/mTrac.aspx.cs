using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class mTrac : System.Web.UI.Page
    {
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
            TextBox1.Text = Global.Mdhere.ToString();
            TextBox2.Text = Global.MDrespond.ToString();
            TextBox3.Text = Global.PAhere.ToString();
            TextBox4.Text = Global.PArespond.ToString();

            TextBox1.BackColor = System.Drawing.Color.Yellow;

            TextBox2.BackColor = System.Drawing.Color.Lime;

            TextBox3.BackColor = System.Drawing.Color.Yellow;

            TextBox4.BackColor = System.Drawing.Color.Lime;

            CancelUnexpectedRePost();
            FindStatus();
        }
        private void FindStatus()
        {
            for (int i = 0; i < Provider.providers.Count(); i++)
            {
                if (Provider.providers[i] != null)
                    if (Provider.providers[i].Status == "Enroute")
                    {
                        Label lbl = new Label();
                        lbl.Width = 250; ;
                        lbl.Font.Size = 20;
                        lbl.BackColor = System.Drawing.Color.Lime;
                      //  btn = new Button() { ID = Provider.providers[i].Name.ToString() + " _btn", Text = "Click When Here" };
                        string btnName = Provider.providers[i].Name;
                        // btn.Click += new EventHandler(Dymanic_Method);
                       // btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };
                        TimeSpan diff = (Provider.providers[i].Eta.Subtract(DateTime.Now));
                        double m = diff.TotalMinutes;
                        m = Math.Round(m, MidpointRounding.AwayFromZero);

                        //    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                        //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                        lbl.Text = Provider.providers[i].Name + " - Enroute" + " ETA: " + m.ToString();
                        if (Provider.providers[i].Type == "MD")
                        {
                            PlaceHolder1.Controls.Add(lbl);
                         //   PlaceHolder1.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder1.Controls.Add(linebreak);
                        }
                        else
                        {
                            PlaceHolder2.Controls.Add(lbl);
                           // PlaceHolder2.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder2.Controls.Add(linebreak);
                        }

                    }
                if (Provider.providers[i] != null)
                    if (Provider.providers[i].Status == "Here")
                    {
                        Label lbl = new Label();
                        lbl.Width = 250; ;
                        lbl.Font.Size = 20;
                        lbl.BackColor = System.Drawing.Color.Yellow;
                        string btnName = Provider.providers[i].Name;
//                        btn = new Button() { ID = btnName + " _btn", Text = "Click When Done" };
                        // btn.Click += new EventHandler(Dymanic_Method);
  //                      btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };



                        //TimeSpan diff = (Provider.providers[i].Eta.Subtract(DateTime.Now));
                        //double m = diff.TotalMinutes;
                        //m = Math.Round(m, MidpointRounding.AwayFromZero);


                        //    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                        //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                        lbl.Text = Provider.providers[i].Name + " - Here" + " at " + Provider.providers[i].Eta.ToString("HHmm");
                        if (Provider.providers[i].Type == "MD")
                        {
                            PlaceHolder3.Controls.Add(lbl);
    //                        PlaceHolder3.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder3.Controls.Add(linebreak);
                        }
                        else
                        {
                            PlaceHolder6.Controls.Add(lbl);
      //                      PlaceHolder6.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder6.Controls.Add(linebreak);
                        }


                    }
                if (Provider.providers[i] != null)
                    if (Provider.providers[i].Status == "Done")
                    {
                        Label lbl = new Label();
                        lbl.Width = 250; ;
                        lbl.Font.Size = 20;
                        lbl.BackColor = System.Drawing.Color.Red;
                        string btnName = Provider.providers[i].Name;
                        //btn = new Button() { ID = btnName + " _btn", Text = "Click When Done" };
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
                        lbl.Width = 250; ;
                        lbl.Font.Size = 20;

                        if (Provider.providers[i].Type == "MD")
                        {
                            lbl.Text = Provider.providers[i].Name;
                            PlaceHolder4.Controls.Add(lbl);

        //                    btn = new Button() { ID = Provider.providers[i].Name.ToString() + " _btn", Text = "Click When Here" };
                            string btnName = Provider.providers[i].Name;
                            // btn.Click += new EventHandler(Dymanic_Method);
          //                  btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };
            //                PlaceHolder4.Controls.Add(btn);
                            LiteralControl linebreak = new LiteralControl("<br>");
                            PlaceHolder4.Controls.Add(linebreak);
                        }


                    }
                if (Provider.providers[i] != null) // list PAs that have not responded
                    if (Provider.providers[i].Status == null)
                    {
                        Label lbl = new Label();
                        lbl.Width = 250; ;
                        lbl.Font.Size = 20;

                        if (Provider.providers[i].Type == "PA")
                        {
                            lbl.Text = Provider.providers[i].Name;
                            PlaceHolder5.Controls.Add(lbl);
              //              btn = new Button() { ID = Provider.providers[i].Name.ToString() + " _btn", Text = "Click When Here" };
                            string btnName = Provider.providers[i].Name;
                            // btn.Click += new EventHandler(Dymanic_Method);
                //            btn.Click += (sender, EventArgs) => { Dymanic_Method(sender, EventArgs, btnName); };
                  //          PlaceHolder5.Controls.Add(btn);
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
                            if (Provider.providers[i].Type == "MD")
                            {
                                Global.Mdhere++;
                                Provider.providers[i].Eta = DateTime.Now;


                            }

                            else
                            {
                                Global.PAhere++;
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
                            if (Provider.providers[i].Type == "MD")
                                Global.Mdhere--;

                            else
                                Global.PAhere--;
                        }
                        if (Provider.providers[i] != null)
                            if (Provider.providers[i].Status == "Enroute")
                            {
                                Provider.providers[i].Status = "Here";
                                if (Provider.providers[i].Type == "MD")
                                {
                                    Global.MDrespond--;
                                    Global.Mdhere++;
                                }
                                else
                                {
                                    Global.PArespond--;
                                    Global.PAhere++;
                                }
                            }
                        if (Provider.providers[i] != null)
                            Provider.providers[i].Eta = DateTime.Now;
                    }
            }
            justShowedUp = false;
            Response.Redirect("~/TestProviderClass.aspx");
        }


    }
}