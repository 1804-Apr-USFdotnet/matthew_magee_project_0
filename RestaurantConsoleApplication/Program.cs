using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace RestaurantConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RestaurantController whatever = new RestaurantController();
            whatever.ProgramLoop();
            Console.Read();
        }
    }
}
