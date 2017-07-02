using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Configure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
              //  string Savepath = Server.MapPath("~/Uploaded/" + FileUpload1.FileName);
                string Savepath = Server.MapPath("~/App_Data/" + FileUpload1.FileName);
                FileUpload1.SaveAs(Savepath);
                Provider.ReadText();

                for (int i = 0; i < Provider.providers.Count(); i++)
                {
                    if (Provider.providers[i] != null)
                    {
                        TextBox1.Text += Provider.providers[i].Name + "\r\n";
                    }
                }

            }
        }
    }
}