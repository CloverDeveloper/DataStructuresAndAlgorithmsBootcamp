using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSeries.Model
{
    public class Recursion
    {
        public string StripZeros(string str) 
        {
            if (string.IsNullOrEmpty(str)) return str;

            if (str.StartsWith("0")) 
            {
                return StripZeros(str.Substring(1));
            }

            return str;
        }
    }
}
