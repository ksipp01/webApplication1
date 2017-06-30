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
    public partial class Track : System.Web.UI.Page
    {

        
        private Boolean IsPageRefresh = false;
        protected void Page_Load(object sender, EventArgs e)
        {

         

            TextBox63.Text = Global.Mdhere.ToString();
            TextBox64.Text = Global.MDrespond.ToString();
            TextBox65.Text = Global.PAhere.ToString();
            TextBox66.Text = Global.PArespond.ToString();
            Label2.BackColor = System.Drawing.Color.Lime;
            Label3.BackColor = System.Drawing.Color.Yellow;
            Label4.BackColor = System.Drawing.Color.Red;
            if (TextBox63.Text == "0")
                TextBox63.BackColor = System.Drawing.Color.Yellow;
            else
                TextBox63.BackColor = System.Drawing.Color.Lime;
            if (TextBox64.Text == "0")
                TextBox64.BackColor = System.Drawing.Color.Yellow;
            else
                TextBox64.BackColor = System.Drawing.Color.Lime;
            if (TextBox65.Text == "0")
                TextBox65.BackColor = System.Drawing.Color.Yellow;
            else
                TextBox65.BackColor = System.Drawing.Color.Lime;
            if (TextBox66.Text == "0")
                TextBox66.BackColor = System.Drawing.Color.Yellow;
            else
                TextBox66.BackColor = System.Drawing.Color.Lime;

            CancelUnexpectedRePost();
            CreateChildControls();
            //if (!IsPostBack)
            //{
            //    ViewState["postids"] = System.Guid.NewGuid().ToString();
            //    Session["postid"] = ViewState["postids"].ToString();
            //}
            //else
            //{
            //    if (ViewState["postids"].ToString() != Session["postid"].ToString())
            //    {
            //        IsPageRefresh = true;
            //    }
            //    Session["postid"] = System.Guid.NewGuid().ToString();
            //    ViewState["postids"] = Session["postid"].ToString();
            //}
            //if (!IsPageRefresh) // prevent page refresh from tiggering again
            //{
            //    CreateChildControls();
            //}




        }

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




        private void CreateChildControls()
        {

            
            var type = typeof(Global);
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
                        placeholder.Controls.Add(lbl);
                        LiteralControl linebreak = new LiteralControl("<br>");
                        placeholder.Controls.Add(linebreak);

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
                        placeholder.Controls.Add(lbl);
                        LiteralControl linebreak = new LiteralControl("<br>");
                        placeholder.Controls.Add(linebreak);

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
                        placeholder.Controls.Add(lbl);
                        LiteralControl linebreak = new LiteralControl("<br>");
                        placeholder.Controls.Add(linebreak);

                    }

                }

            }

                        //  }
                 

        

        }

    }
}