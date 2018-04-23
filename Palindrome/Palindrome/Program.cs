using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPalindrome checker = new CheckPalindrome();
            Console.WriteLine(checker.PalendromSearch("ra.,,.cecar"));
            Console.Read();
        }
    }
}
