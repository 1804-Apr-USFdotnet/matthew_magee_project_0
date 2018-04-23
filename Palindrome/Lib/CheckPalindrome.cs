using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lib
{
    public class CheckPalindrome
    {

        public bool IsPalendrome { get; set; }

        public bool PalendromSearch(string searchString)
        {
            searchString = Regex.Replace(searchString, @"[\W_]", string.Empty).ToLower();
            Console.WriteLine(searchString);
            char[] array = searchString.ToCharArray();
            Array.Reverse(array);
            string reversed = new string(array);
            return searchString == reversed;
        }
    }
}
