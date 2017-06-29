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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //  TextBox1.Text = Provider.providers[4].Name + " " + Provider.providers[4].Type;
            FindStatus();
        }

        private void FindStatus()
        {
            for(int i = 0; i < Provider.providers.Count(); i++)
            {
                if (Provider.providers[i].Status == "Enroute")
                {
                    Label lbl = new Label();
                    lbl.Width = 200;
                    lbl.BackColor = System.Drawing.Color.Lime;


                    TimeSpan diff = (Provider.providers[i].Eta.Subtract(DateTime.Now));
                    double m = diff.TotalMinutes;
                    m = Math.Round(m, MidpointRounding.AwayFromZero);
                   

                    //    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                    lbl.Text = Provider.providers[i].Name + " - Enroute" + " ETA: " + m.ToString();
                    PlaceHolder1.Controls.Add(lbl);
                    LiteralControl linebreak = new LiteralControl("<br>");
                    PlaceHolder1.Controls.Add(linebreak);
                }
            }
        }


        private void CreateChildControls()
        {


            var type = typeof(Provider);
            //   var field = type.GetField(name);
            //   Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();



            //var prop = type.GetProperty(name);


            foreach (PropertyInfo property in properties)
            {

                //  string NameStatus = RemoveSpace(name) + "Status";
                //var status = type.GetProperty(nameStatus);
                // var name = status.Name;
                // var s = status.GetValue(null);
                //if (status.GetValue(null).ToString() == "Enroute")
                //{
                string val = property.Name.ToString();
                if (val.Contains("Status"))
                {
                    var status = type.GetProperty(val);
                    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                    if (status.GetValue(null).ToString() == "Enroute")
                    {
                        Label lbl = new Label();
                        lbl.Width = 200;
                        lbl.BackColor = System.Drawing.Color.Lime;
                        //    string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                        //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                        lbl.Text = name + " - Enroute";
                        PlaceHolder1.Controls.Add(lbl);
                        LiteralControl linebreak = new LiteralControl("<br>");
                        PlaceHolder1.Controls.Add(linebreak);

                    }
                    //if (status.GetValue(null).ToString() == "Here")
                    //{
                    //    Label lbl = new Label();
                    //    lbl.Width = 200;
                    //    lbl.BackColor = System.Drawing.Color.Yellow;
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Arrvied";
                    //    placeholder.Controls.Add(lbl);
                    //    LiteralControl linebreak = new LiteralControl("<br>");
                    //    placeholder.Controls.Add(linebreak);

                    //}
                    //if (status.GetValue(null).ToString() == "Done")
                    //{
                    //    Label lbl = new Label();
                    //    lbl.Width = 200;
                    //    lbl.BackColor = System.Drawing.Color.Red;
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Done";
                    //    placeholder.Controls.Add(lbl);
                    //    LiteralControl linebreak = new LiteralControl("<br>");
                    //    placeholder.Controls.Add(linebreak);

                    //}

                }
            }
            foreach (PropertyInfo property in properties)
            {

                //  string NameStatus = RemoveSpace(name) + "Status";
                //var status = type.GetProperty(nameStatus);
                // var name = status.Name;
                // var s = status.GetValue(null);
                //if (status.GetValue(null).ToString() == "Enroute")
                //{
                string val = property.Name.ToString();
                string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                if (val.Contains("Status"))
                {
                    var status = type.GetProperty(val);
                    //if (status.GetValue(null).ToString() == "Enroute")
                    //{
                    //    Label lbl = new Label();
                    //    lbl.Width = 200;
                    //    lbl.BackColor = System.Drawing.Color.Lime;
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                    //    placeholder.Controls.Add(lbl);
                    //    LiteralControl linebreak = new LiteralControl("<br>");
                    //    placeholder.Controls.Add(linebreak);

                    //}
                    if (status.GetValue(null).ToString() == "Here")
                    {
                        Label lbl = new Label();
                        lbl.Width = 200;
                        lbl.BackColor = System.Drawing.Color.Yellow;
                        //  lbl.Text = property.Name.ToString().Replace("Status", "") + " - Arrvied";
                        lbl.Text = name + " - Arrived";
                        PlaceHolder1.Controls.Add(lbl);
                        LiteralControl linebreak = new LiteralControl("<br>");
                        PlaceHolder1.Controls.Add(linebreak);

                    }
                    //if (status.GetValue(null).ToString() == "Done")
                    //{
                    //    Label lbl = new Label();
                    //    lbl.Width = 200;
                    //    lbl.BackColor = System.Drawing.Color.Red;
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Done";
                    //    placeholder.Controls.Add(lbl);
                    //    LiteralControl linebreak = new LiteralControl("<br>");
                    //    placeholder.Controls.Add(linebreak);

                    //}

                }
            }
            foreach (PropertyInfo property in properties)
            {

                //  string NameStatus = RemoveSpace(name) + "Status";
                //var status = type.GetProperty(nameStatus);
                // var name = status.Name;
                // var s = status.GetValue(null);
                //if (status.GetValue(null).ToString() == "Enroute")
                //{
                string val = property.Name.ToString();
                string name = Regex.Replace(property.Name.ToString().Replace("Status", ""), "([a-z])_?([A-Z])", "$1 $2");
                if (val.Contains("Status"))
                {
                    var status = type.GetProperty(val);
                    //if (status.GetValue(null).ToString() == "Enroute")
                    //{
                    //    Label lbl = new Label();
                    //    lbl.Width = 200;
                    //    lbl.BackColor = System.Drawing.Color.Lime;
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Enroute";
                    //    placeholder.Controls.Add(lbl);
                    //    LiteralControl linebreak = new LiteralControl("<br>");
                    //    placeholder.Controls.Add(linebreak);

                    //}
                    //if (status.GetValue(null).ToString() == "Here")
                    //{
                    //    Label lbl = new Label();
                    //    lbl.Width = 200;
                    //    lbl.BackColor = System.Drawing.Color.Yellow;
                    //    lbl.Text = property.Name.ToString().Replace("Status", "") + " - Arrvied";
                    //    placeholder.Controls.Add(lbl);
                    //    LiteralControl linebreak = new LiteralControl("<br>");
                    //    placeholder.Controls.Add(linebreak);

                    //}
                    if (status.GetValue(null).ToString() == "Done")
                    {
                        Label lbl = new Label();
                        lbl.Width = 200;
                        lbl.BackColor = System.Drawing.Color.Red;
                        //  lbl.Text = property.Name.ToString().Replace("Status", "") + " - Done";
                        lbl.Text = name + " - Done";
                        PlaceHolder1.Controls.Add(lbl);
                        LiteralControl linebreak = new LiteralControl("<br>");
                        PlaceHolder1.Controls.Add(linebreak);

                    }

                }

            }
        }
    }
}