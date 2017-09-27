using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Testing_Logfiles;

namespace Testing_Logfiles
{
   public class LogReader
    {

        

        public string ReadLog(string path)
        {
            return File.ReadAllText(path);
        }

        public string[] LogToStringArray(string path)
        {
            return File.ReadAllLines(path);
        }

    }
}
