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
        private static bool activeSession;

        private static string _emailPswd;
        private static string _emailTo;

        public static string EmailPswd
        {
            get
            {
                return _emailPswd;
            }
            set
            {
                _emailPswd = value;
            }
        }
       
        public static string EmailTo
        {
            get
            {
                return _emailTo;
            }

            set
            {
                _emailTo = value;
            }
        }
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
                int number = 0;
                for (int i = 0; i < providers.Count(); i++)
                {
                    if (Provider.providers[i] != null)
                    {
                        if (providers[i].Status == "Enroute" && providers[i].Type == "MD")
                            number++;
                        
                    }
                }
                _MDrespond = number;

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
                int number = 0;
                for (int i = 0; i < providers.Count(); i++)
                {
                    if (Provider.providers[i] != null)
                    {
                        if (providers[i].Status == "Here" && providers[i].Type == "MD")
                            number++;

                    }
                }
                _Mdhere = number;
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
                int number = 0;
                for (int i = 0; i < providers.Count(); i++)
                {
                    if (Provider.providers[i] != null)
                    {
                        if (providers[i].Status == "Enroute" && providers[i].Type == "PA")
                            number++;

                    }
                }
                _PArespond = number;
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
                int number = 0;
                for (int i = 0; i < providers.Count(); i++)
                {
                    if (Provider.providers[i] != null)
                    {
                        if (providers[i].Status == "Here" && providers[i].Type == "PA")
                            number++;

                    }
                }
                _PAhere = number;
                return _PAhere;
            }

            set
            {
                _PAhere = value;
            }
        }

        public static bool ActiveSession
        {
            get
            {
                return activeSession;
            }

            set
            {
                activeSession = value;
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


        public static void ReadText(string path)
        {
            string type = "";
         //   Global1.Startup = true;
            //  Provider[] providers = new Provider[3];
            activeSession = true;
            //string path = @"C:\temp\test.txt";
       //     string path = HttpContext.Current.Server.MapPath("~/App_Data/Test.txt");
            if (File.Exists(path))
            {
                using (StreamReader textFile = new StreamReader(path))
                {
                    int index = 0;

                    while (!textFile.EndOfStream)
                    {
                        Provider p = new Provider();
                        string read = textFile.ReadLine();
                       if (read.Substring(0,2) == "en")
                        {
                            _emailTo = p.Between(read, "To:", "Pswd:");
                            _emailPswd = p.After(read, "Pswd:");
                            break;
                        }
                           
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
        private string Between(string value, string a, string b)
        {
            int posA = value.IndexOf(a);
            int posB = value.LastIndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }
        public string After(string value, string a)
        {
            int posA = value.LastIndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= value.Length)
            {
                return "";
            }
            return value.Substring(adjustedPosA);
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
            Log.Logstring += "Form Reset  - " + DateTime.Now.ToString("MM/dd/yyyy HHmm") + "hrs\r\n";
            Log.LogFile("Form Reset  - " + DateTime.Now.ToString("MM/dd/yyyy HHmm"));
            Provider.ActiveSession = false;
        }

    }
}