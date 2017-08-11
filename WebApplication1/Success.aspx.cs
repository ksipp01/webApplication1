using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Timers;

namespace WebApplication1
{
    public partial class Success : System.Web.UI.Page
    {
        //bool autoclose = false;
        //System.Timers.Timer timer1 = new System.Timers.Timer(5000);
     
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!autoclose)
            //{
            //    timer1.Start();
            //    timer1.Elapsed += OnTimedEvent;
            //}
            //else
                this.ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.open('close.html', '_self', null);", true);

        }
        //private  void OnTimedEvent(Object source, ElapsedEventArgs e)
        //{
        //    timer1.Stop();
        //    //  ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.open('close.html', '_self', null);", true);
        //    autoclose = true;
            
        //    //   Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "ClosePage", "window.close();", true);
        //}

      
    }
}