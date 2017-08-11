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
  
        protected void Page_Load(object sender, EventArgs e)
        {
           // this will close some browsers doesn't work for safari
          //      this.ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.open('close.html', '_self', null);", true);

        }
     

      
    }
}