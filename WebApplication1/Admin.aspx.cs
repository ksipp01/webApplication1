using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Admin : System.Web.UI.Page
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

     
        private void SetBackColor(Control Parentcontrol)
        {

            if (Parentcontrol.HasControls())
            {
                foreach (Control c in Parentcontrol.Controls)
                {
                    SetBackColor(c);
                    TextBox tb = c as TextBox;
                    if (tb != null)
                    {
                        //  if (tb.Text != "" && tb.BackColor != System.Drawing.Color.WhiteSmoke)
                        //if (tb.Text == "" || tb.Text.Contains("hrs"))
                        //    tb.BackColor = tb.BackColor;
                       // else
                       if (tb.Text == "Enroute")
                            tb.BackColor = System.Drawing.Color.Lime;
                        if (tb.Text == "Here")
                        {
                            tb.Text = "Arrived";
                            tb.BackColor = System.Drawing.Color.Yellow;
                        }
                        if (tb.Text == "Done")
                            tb.BackColor = System.Drawing.Color.Red;
                        //if (tb.Text != "" && tb.Text.Substring(0, 1) == "-")
                        //{
                        //    //  tb.BackColor = System.Drawing.Color.Li;
                        //    tb.BorderColor = System.Drawing.Color.Red;
                        //    tb.BorderWidth = 3;
                        //}
                        if (tb.Text == "MD" || tb.Text == "PA")
                            tb.Text = "";
                    }
                }
                if (TextBox59.Text == "0")
                    TextBox59.BackColor = System.Drawing.Color.Yellow;
                else
                    TextBox59.BackColor = System.Drawing.Color.Lime;
                if (TextBox60.Text == "0")
                    TextBox60.BackColor = System.Drawing.Color.Yellow;
                else
                    TextBox60.BackColor = System.Drawing.Color.Lime;
                if (TextBox61.Text == "0")
                    TextBox61.BackColor = System.Drawing.Color.Yellow;
                else
                    TextBox61.BackColor = System.Drawing.Color.Lime;
                if (TextBox62.Text == "0")
                    TextBox62.BackColor = System.Drawing.Color.Yellow;
                else
                    TextBox62.BackColor = System.Drawing.Color.Lime;
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

                CheckStatus();


                SetBackColor(Page);
            }

            //SetBackColor(Page);
            //CheckStatus();
            //if (!Page.IsPostBack)
            //{


            //    SetBackColor(Page);
            //    CheckStatus();


            
            //    //  TextBox1.Text = Server.HtmlEncode(Request.Cookies["user"].Value);
            //}

        }
        private void CheckStatus()
        {
            TextBox60.Text = Global.MDrespond.ToString();
            TextBox59.Text = Global.Mdhere.ToString();
            TextBox61.Text = Global.PAhere.ToString();
            TextBox62.Text = Global.PArespond.ToString();


            TextBox32.Text = Global.KarenAndersonStatus;
            TextBox33.Text = Global.LaresaDeboerStatus;
            TextBox34.Text = Global.DanDeweyStatus;
            TextBox35.Text = Global.JoseDundeeStatus;
            TextBox36.Text = Global.SarahDundeeStatus;
            TextBox37.Text = Global.SaraFishStatus;
            TextBox38.Text = Global.ErineFongStatus;
            TextBox39.Text = Global.MattHeroldStatus;
            TextBox40.Text = Global.BruceHubbardStatus;
            TextBox41.Text = Global.ValerieJohnsonStatus;
            TextBox42.Text = Global.DaveLarsonStatus;
            TextBox43.Text = Global.LisaLarsonStatus;
            TextBox44.Text = Global.AmyOsbornStatus;
            TextBox45.Text = Global.GregPetersonStatus;
            TextBox46.Text = Global.YoSchugelStatus;
            TextBox47.Text = Global.KevinSipprellStatus;
            TextBox48.Text = Global.EmilyAndersonStatus;
            TextBox49.Text = Global.JerodBarnesStatus;
            TextBox50.Text = Global.ErinBischoffStatus;
            TextBox51.Text = Global.FredDemeuseStatus;
            TextBox52.Text = Global.ChelseaErnisseStatus;
            TextBox53.Text = Global.AllisonEngelsmaStatus;
            TextBox54.Text = Global.BradyGriffithStatus;
            TextBox55.Text = Global.JasonHicksStatus;
            TextBox56.Text = Global.BethRadkeStatus;
            TextBox57.Text = Global.TamrahTenhaeffStatus;
            TextBox58.Text = Global.ErinnVonreinStatus;

            //if (Global.KarenAndersonStatus == "MD")
            //    return;

            //if (Global.KarenAndersonStatus == "Enroute")
            //{
            //    TimeSpan diff = (Global.KarenAnderson.Subtract(DateTime.Now));
            //    double m = diff.TotalMinutes;
            //    m = Math.Round(m, MidpointRounding.AwayFromZero);
            //    TextBox32.Text = "ETA: " +  m.ToString();

            //    //if (diff.TotalMinutes >= 0)
            //    //    TextBox1.Text = diff.ToString("mm");
            //    //else
            //    //    TextBox1.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.KarenAndersonStatus == "Here")
            //{
            //    TextBox32.Text = Global.KarenAnderson.ToString("HHmm") + ("hrs");
            //    TextBox32.BackColor = System.Drawing.Color.Yellow;

            //}
            //else if (Global.KarenAndersonStatus == "Done")
            //{
            //    TextBox32.BackColor = System.Drawing.Color.Red;
            //    TextBox32.Text = Global.KarenAnderson.ToString("HHmm") + ("hrs");

            //}
        }
 
    }
}