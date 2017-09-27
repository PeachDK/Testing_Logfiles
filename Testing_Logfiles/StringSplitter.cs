using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Testing_Logfiles
{
    class StringSplitter
    {   
        public string[] SeperateString(string input)
        {
            return input.Split('\t');
        }
    }
}