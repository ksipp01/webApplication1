using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{


    //this copies the contents of the configure text file to a .txt file on the server.  

    public partial class Configure : System.Web.UI.Page
    {
        public static string Savepath;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
              //  string Savepath = Server.MapPath("~/Uploaded/" + FileUpload1.FileName);
                Savepath = Server.MapPath("~/App_Data/" + FileUpload1.FileName);
                FileUpload1.SaveAs(Savepath + "EMPAC_Tracker_config.txt");
                Provider.ReadText(Savepath);

                for (int i = 0; i < Provider.providers.Count(); i++)
                {
                    if (Provider.providers[i] != null)
                    {
                        TextBox1.Text += Provider.providers[i].Name + "\r\n";
                    }
                }
                TextBox1.Text += "Email to: " + Provider.EmailTo;
            }
        }
    }
}