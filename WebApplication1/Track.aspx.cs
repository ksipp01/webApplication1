using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace WebApplication1
{
    public partial class Track : System.Web.UI.Page
    {

        private Boolean IsPageRefresh = false;
        protected void Page_Load(object sender, EventArgs e)
        {

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




        private static string name = "KevinSipprell";
        private static string nameStatus = "KevinSipprellStatus";
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
                    if (status.GetValue(null).ToString() == "Enroute")
                    {
                        Label lbl = new Label();
                        lbl.BackColor = System.Drawing.Color.Lime;
                        lbl.Text = property.Name.ToString().Replace("Status", "");
                        placeholder.Controls.Add(lbl);
                        LiteralControl linebreak = new LiteralControl("<br>");
                        placeholder.Controls.Add(linebreak);
                        
                    }
                }
              //  }
            }

        

        }

    }
}