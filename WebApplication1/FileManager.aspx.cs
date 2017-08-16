using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;

namespace WebApplication1
{
    public partial class FileManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateListBox(ListBox1, Server.MapPath("~/App_Data"), "*.txt");

        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            if (!IsPostBack)
            {
                DirectoryInfo dinfo = new DirectoryInfo(Folder);
                FileInfo[] Files = dinfo.GetFiles(FileType);
                foreach (FileInfo file in Files)
                {
                    if (file.Name != "EMPAC_tracker_config.txt") // dont want to allow deletion of config file.  
                        lsb.Items.Add(file.Name);
                }
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            foreach(ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                    File.Delete(Server.MapPath("~/App_Data/") + item.ToString());

            }
            ListBox1.DataBind();
            Response.Redirect("~/FileManager.aspx");
            //for (int x = ListBox1.GetSelectedIndices().Count() - 1; x >= 0; x--)
            //{
            //    File.Delete(Server.MapPath("~/App_Data/") + ListBox1.SelectedValue.ToString());
            //}


        }
    }
}