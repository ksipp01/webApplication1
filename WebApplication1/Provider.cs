using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
namespace WebApplication1
{
    public class Provider
    {
        private string _name;
        private string _status;
        private string _type;
        private DateTime _eta;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public DateTime Eta
        {
            get
            {
                return _eta;
            }

            set
            {
                _eta = value;
            }
        }

        public static int MDrespond
        {
            get
            {
                return _MDrespond;
            }

            set
            {
                _MDrespond = value;
            }
        }

        public static int Mdhere
        {
            get
            {
                return _Mdhere;
            }

            set
            {
                _Mdhere = value;
            }
        }

        public static int PArespond
        {
            get
            {
                return _PArespond;
            }

            set
            {
                _PArespond = value;
            }
        }

        public static int PAhere
        {
            get
            {
                return _PAhere;
            }

            set
            {
                _PAhere = value;
            }
        }

        public Provider (string name, string status, string type, DateTime eta)
        {
            _name = name;
            _status = status;
            _type = type;
            _eta = eta;
        }
        public Provider(string name, string status, DateTime eta)
        {
            _name = name;
            _status = status;
            _eta = eta;
        }
        public Provider(string name, string status)
        {
            _name = name;
            _status = status;
  
        }
        public Provider(string name)
        {
            _name = name;
       

        }
        public Provider ()
        { }

        public static Provider[] providers = new Provider[100];

        private static int _MDrespond = 0;
        private static int _Mdhere = 0;
        private static int _PArespond = 0;
        private static int _PAhere = 0;


        public static void ReadText()
        {
            string type = "";
            //  Provider[] providers = new Provider[3];
            //string path = @"C:\temp\test.txt";
            string path = HttpContext.Current.Server.MapPath("~/App_Data/Test.txt");
            if (File.Exists(path))
            {
                using (StreamReader textFile = new StreamReader(path))
                {
                    int index = 0;

                    while (!textFile.EndOfStream)
                    {
                        Provider p = new Provider();
                        string read = textFile.ReadLine();
                        if (read == "end")
                            break;
                        if (read == "MD")
                        {
                            type = "MD";

                        }
                        else if (read == "PA")
                        {
                            type = "PA";

                        }
                        else {

                            p.Name = read;
                            p.Type = type;
                        }
                        if (read != "MD" && read != "PA")
                            providers[index++] = p;
                    }


                }
            }
            else
                HttpContext.Current.Response.Redirect("~/configure.aspx");
                
           
        }
        public static void Reset()
        {
        
                for (int i = 0; i < providers.Count(); i++)
                {
                if (Provider.providers[i] != null)
                {
                    providers[i].Status = null;
                    providers[i].Eta = DateTime.MinValue;
                }      
                }
            Provider.Mdhere = 0;
            Provider.MDrespond = 0;
            Provider.PAhere = 0;
            Provider.PArespond = 0;
        }

    }
}