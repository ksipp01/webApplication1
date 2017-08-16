#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;

namespace WebApplication1
{

    public class Global1 : System.Web.HttpApplication
    {
        //private static bool startup = false;

        //public static bool Startup
        //{
        //    get
        //    {
        //        return startup;
        //    }

        //    set
        //    {
        //        startup = value;
        //    }
        //}

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {



            Configure.Savepath = Server.MapPath("~/App_Data/" + "EMPAC_Tracker_config.txt");
            if (!Provider.ActiveSession)
                Log.LogPath = Server.MapPath("~/App_Data/" + "EMPAC_Tracker_Log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt"); 
            // save a log file based on day of  date.  this will be appended until new day of month AND reset provider class
            
            // if (!Startup) //read the .txt file on the server to populate th3 global.provider class.   only done at first session start
            //{
            //    if (!File.Exists(Configure.Savepath))
            //        Response.Redirect("~/configure.aspx");
            //    else
            //    {
            //        Provider.ReadText(Configure.Savepath);
            //        //  Log.Logstring = "";
            //        if (Log.Logstring == "")
            //        {

            //            Log.Logstring += "EMPAC Provider Tracker:  Begin  - " + DateTime.Now.ToString("MM/dd/yyyy HHmm") + "hrs\r\n";
            //        }
            //        if (!File.Exists(Log.LogPath))
            //            File.WriteAllText(Log.LogPath, Log.Logstring);
            //    }
            //}
            //Provider[] providers = new Provider[3];
            //string path = @"C:\temp\test.txt";
            //using (StreamReader textFile = new StreamReader(path))
            //{
            //    int index = 0;
            //    while (!textFile.EndOfStream)
            //    {
            //        Provider p = new Provider();
            //        p.Name = textFile.ReadLine();
            //        p.Status = textFile.ReadLine();
            //        p.Type = textFile.ReadLine();

            //        providers[index++] = p;
            //    }


            //}

            //
            //HttpRequest _httpRequest = HttpContext.Current.Request;
            //if (_httpRequest.Browser.IsMobileDevice)
            //{
            //    string _path = _httpRequest.Url.PathAndQuery;
            //    bool _isMobileDevice = _path.StartsWith("/Mobile");
            //    if (!_isMobileDevice)
            //    {
            //        string _redirectTo = "/Mobile";
            //        HttpContext.Current.Response.Redirect(_redirectTo);
            //    }
            //}

            //      HttpRequest _httpRequest = HttpContext.Current.Request;

            //remd all for now 6-23-17
            //if (_httpRequest.Browser.IsMobileDevice)
            //{
            //    //if (_httpRequest.Path == "/index.aspx")
            //    //    return;
            //    //else
            //    {
            //        string _redirectTo = "/Login.aspx";
            //        HttpContext.Current.Response.Redirect(_redirectTo);
            //    }
            //    //string _path = _httpRequest.Url.PathAndQuery;
            //    //bool _isMobileDevice = _path.StartsWith("/Mobile");
            //    //if (!_isMobileDevice)
            //    //{
            //    //    string _redirectTo = "/Mobile";
            //    //    HttpContext.Current.Response.Redirect(_redirectTo);
            //    //}
            //}


        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
//            Log.Logstring += "EMPAC Provider Tracker:  Session Ended - " + DateTime.Now.ToString("MM/dd/yyyy HHmm") + " hrs\r\n";
//            Log.LogFile("EMPAC Provider Tracker:  Session Ended - " + DateTime.Now.ToString("MM/dd/yyyy HHmm"));
//#if (DEBUG == false)
//            Log.SendEmail();
//#endif
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}