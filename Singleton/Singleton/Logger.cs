using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
     class Logger
    {
        private string fileName;
        private StreamWriter sw;
        private static Logger instance;
        public static Logger Instance { get
            {

                if(instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
        private Logger()
        {
            fileName = $"{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";
            sw= new StreamWriter(fileName);
        }

       

        public void Write(string data)
        {
            sw.WriteLine($"{DateTime.Now} -- {data}");
            sw.Flush();
        }
    }
}
