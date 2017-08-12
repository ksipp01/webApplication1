using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Net.Mail;
using System.Reflection;


namespace WebApplication1
{
    public partial class Log : System.Web.UI.Page
    {
        private static string _logstring;
        private Boolean IsPageRefresh = false;

       




        public static string Logstring
        {
            get
            {
                return _logstring;
            }

            set
            {
                _logstring = value;
            }
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
        protected void Page_Load(object sender, EventArgs e)
        {
            //this doesn't work.  still re-wristes log

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



            if (!IsPageRefresh)
            {
                //   _logstring += Request.QueryString["val"];
                if (_logstring == String.Empty)
                    TextBox1.Text = String.Empty;

                TextBox1.Text += _logstring;
            }
            //if (Session["value"] != null)
            //TextBox1.Text = Session["value"].ToString();
        }
        public void ClearLog()
        {
            _logstring = "";
            TextBox1.Text = string.Empty;
            _logstring += "EMPAC Provider Tracker:  Begin  - " + DateTime.Now.ToString("MM/dd/yyyy HHmm") + " hrs\n";
            Response.Redirect("~/log.aspx");
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            ClearLog();
            //_logstring = "";
            //TextBox1.Text = string.Empty;
            //_logstring += "EMPAC Provider Tracker:  Begin  - " + DateTime.Now.ToString("MM/dd/yyyy HHmm") + "hrs\n";
            //Response.Redirect("~/log.aspx");
        }

       



        protected void Button2_Click(object sender, EventArgs e) // save
        {
            //    var datafile = Server.MapPath("~/App_data/log.txt");
            StringBuilder sb = new StringBuilder();
          //  string output = "Output";
            sb.Append(_logstring);
            sb.Append("\r\n");
            string text = sb.ToString();

            Response.Clear();
            Response.ClearHeaders();

            Response.AddHeader("Content-Length", text.Length.ToString());
            Response.ContentType = "text/plain";
        
            //   Response.AppendHeader("content-disposition", "attachment;filename=\"EMPAC-Tracker Log.txt\"");
            Response.AppendHeader("content-disposition", "attachment;filename=\"EMPAC_Tracker" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt");
            Response.Write(text);
    
            Response.End();

        }

        public static void SendEmail()
        {
            if (Provider.EmailTo != "")
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    //  string output = "Output";
                    sb.Append(_logstring);
                    sb.Append("\r\n");
                    string text = sb.ToString();

                    MailMessage Mail = new MailMessage();

                    Mail.IsBodyHtml = true;
                    Mail.Body = text;
                    Mail.BodyEncoding = System.Text.Encoding.ASCII;
                    Mail.Body = Mail.Body.Replace(Environment.NewLine, "<br/>");

                    Mail.Subject = ("EMPAC Tracker Log" + DateTime.Now.ToString("yyyyMMddHHmm"));
                    Mail.From = new MailAddress("EMPACTracker@EMPAC-Tracker.azurewebsites.net");

                    Mail.To.Add(new MailAddress(Provider.EmailTo));
                    //Attachment attach = new Attachment(file);
                    //Mail.Attachments.Add(attach);

                    System.Net.Mail.SmtpClient Smtp = new SmtpClient();

                    Smtp.Host = ("smtp.sendgrid.net"); // for example gmail smtp server

                    Smtp.EnableSsl = true;
                    Smtp.Port = 587;
                    //    textBox27.Text = user.ToString();
                    Smtp.Credentials = new System.Net.NetworkCredential("azure_4c4e0cc6f7169324ca1f9cae62ab0822@azure.com", Provider.EmailPswd);
                    //      Smtp.Credentials = new System.Net.NetworkCredential("fleetadd01@gmail.com", "");

                    Smtp.Send(Mail);
                    //FileLog("message sent to " + to.ToString());
                    //Log("message sent to " + to.ToString());

                }
                catch (SmtpFailedRecipientException ex)
                {
                    //    Log("Send Mail Error" + ex.ToString());
                    //    //  Send("Send Mail Error" + ex.ToString());
                    //    FileLog("Send Mail Error" + ex.ToString());
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SendEmail();
        }




        //protected void Button2_Click(object sender, EventArgs e)
        //{

        //    TextBox1.Text += " *******EMPAC_Log.txt saved to My Documents********";
        //    string mydocpath =
        //    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    var line = _logstring.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        //    // Write the string array to a new file named "WriteLines.txt".
        //    using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\EMPAC_Log.txt"))
        //    {
        //        foreach (var s in line)
        //            outputFile.WriteLine(s);
        //    }

        //        //    string output = "Output";
        //        //  sb.AppendFormat("{0}<br />", _logstring);
        //        //   sb.Append(_logstring);

        //        //   //   sb.Append("\r\n");
        //        //sb.Replace(Environment.NewLine, "<br />").ToString();
        //        //   string text = sb.ToString();







        //  //      StringBuilder sb = new StringBuilder();

        //  //      Response.Clear();
        //  //  Response.ClearHeaders();

        //  //  //   Response.AddHeader("Content-Length", text.Length.ToString());
        //  //  Response.AddHeader("Content-Length", _logstring.Length.ToString());
        //  //  Response.ContentType = "text/plain";
        //  ////  Response.ContentType = "application/octet-stream";
        //  //  Response.AppendHeader("content-disposition", "attachment;filename=\"log.txt\"");
        //  //  string output = _logstring.Replace("\n\r", "<br>");
        //  //  // Response.Write(text);
        //  //  Response.Write(output);
        //  //  Response.End();








        //    //  var datafile = Server.MapPath("~/App_data/log.txt");
        //    //File.WriteAllText(@datafile, _logstring);

        // //   Response.Clear();
        // //   Response.AppendHeader("Content-Disposition", "attachment; filename=log.txt");
        // ////   Response.AppendHeader("", "attachment; filename=log.txt");
        // //   //     Response.AppendHeader("Content-Length", _logstring.Length.ToString());
        // //   Response.ContentType = "text/plain";
        // //   Response.Write(_logstring);
        // //   Response.Flush();
        // //   Response.End();

        //}
    }
}