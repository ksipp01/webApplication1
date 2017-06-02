using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DaveLarson : System.Web.UI.Page
    {
        private string name;
        private string RemoveSpace(string s)
        {

            string trim = s.Substring(s.IndexOf('~') + 2);
            int index = 0;
            foreach (Char c in trim)
            {
                if (Char.IsUpper(c) && index > 2) break;
                index++;

            }
            return trim.Insert(index, " ").Substring(0, trim.LastIndexOf(".") + 1);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            name = RemoveSpace(this.AppRelativeVirtualPath.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Global.MDrespond++;
            Global.DaveLarsonStatus = "Enroute";
            int minutes = Convert.ToInt16(TextBox1.Text);
            DateTime time = DateTime.Now;
            TimeSpan eta = new TimeSpan(0, minutes, 0);
            Global.DaveLarson = time.Add(eta);
            // Global.DaveLarson = TextBox1.Text;
            TextBox1.BackColor = System.Drawing.Color.Lime;
            string responded = name + " Responded: " + TextBox1.Text + " min ETA at " + DateTime.Now.ToString();
            Log.Logstring += responded + "\n";
        }
    }
}