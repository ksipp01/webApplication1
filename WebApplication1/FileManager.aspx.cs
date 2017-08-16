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
                  //  if (file.Name != "EMPAC_tracker_config.txt") // dont want to allow deletion of config file.  
                        lsb.Items.Add(file.Name);
                }
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            foreach(ListItem item in ListBox1.Items)
            {
                if (item.Selected && item.ToString() != "EMPAC_tracker_config.txt")
                        File.Delete(Server.MapPath("~/App_Data/") + item.ToString());

            }
            ListBox1.DataBind();
            Response.Redirect("~/FileManager.aspx");
            //for (int x = ListBox1.GetSelectedIndices().Count() - 1; x >= 0; x--)
            //{
            //    File.Delete(Server.MapPath("~/App_Data/") + ListBox1.SelectedValue.ToString());
            //}


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                //   File.Delete(Server.MapPath("~/App_Data/") + item.ToString());
                {


                    string fileName = Server.MapPath("~/App_Data/") + item.ToString();

                    System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
                    response.ClearContent();
                    response.Clear();
                    response.ContentType = "text/plain";
                    response.AddHeader("Content-Disposition", "attachment; filename=" + item.ToString() + ";");
                    response.TransmitFile(Server.MapPath("~/App_Data/") + item.ToString());
                    response.Flush();
                    response.End();

                }
              
            }


            //Response.Clear();
            //Response.ClearHeaders();

            //Response.AddHeader("Content-Length", text.Length.ToString());
            //Response.ContentType = "text/plain";

            ////   Response.AppendHeader("content-disposition", "attachment;filename=\"EMPAC-Tracker Log.txt\"");
            //Response.AppendHeader("content-disposition", "attachment;filename=\"EMPAC_Tracker" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt");
            //Response.Write(text);
            //File.WriteAllText(Server.MapPath("~/App_Data/" + "EMPAC_Tracker" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt"), text);
            //Response.End();
        }

    
    }
}