using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
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

        public static Provider[] providers = new Provider[300];
        
        public static void ReadText()
        {
            string type = "";
            //  Provider[] providers = new Provider[3];
            string path = @"C:\temp\test.txt";
            using (StreamReader textFile = new StreamReader(path))
            {
                int index = 0;
               
                while (!textFile.EndOfStream)
                {

                    if (textFile.ReadLine() == "MD")
                        type = "MD";
                    if (textFile.ReadLine() == "PA")
                        type = "PA";
                    Provider p = new Provider();
                    p.Name = textFile.ReadLine();
                    p.Type = type;

                    providers[index++] = p;
                }


            }
        }


    }
}