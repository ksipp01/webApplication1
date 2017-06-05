using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global1 : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //
            HttpRequest _httpRequest = HttpContext.Current.Request;
            if (_httpRequest.Browser.IsMobileDevice)
            {
                string _path = _httpRequest.Url.PathAndQuery;
                bool _isMobileDevice = _path.StartsWith("/Mobile");
                if (!_isMobileDevice)
                {
                    string _redirectTo = "/Mobile";
                    HttpContext.Current.Response.Redirect(_redirectTo);
                }
            }
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