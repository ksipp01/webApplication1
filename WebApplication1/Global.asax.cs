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

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Provider.ReadText();
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

                HttpRequest _httpRequest = HttpContext.Current.Request;
            Log.Logstring += "EMPAC Casualty Response Provider Tracker:  Begin  - " + DateTime.Now.ToString("MM/dd/yyyy HHmm") + "hrs\n";
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
            
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}