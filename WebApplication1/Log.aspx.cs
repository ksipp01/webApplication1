using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

namespace WebApplication1
{
    public partial class Log : System.Web.UI.Page
    {
        private static string _logstring;

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

        protected void Page_Load(object sender, EventArgs e)
        {
            //   _logstring += Request.QueryString["val"];
            TextBox1.Text = String.Empty;
            TextBox1.Text += _logstring;
            
            //if (Session["value"] != null)
            //TextBox1.Text = Session["value"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _logstring = "";
            TextBox1.Text = string.Empty;
            _logstring += "EMPAC Provider Tracker:  Begin  - " + DateTime.Now.ToString("MM/dd/yyyy HHmm") + "hrs\n";
            Response.Redirect("~/log.aspx");
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