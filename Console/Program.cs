﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var whatever = new RestaurantController();
            whatever.InitialStartup();
            
            
            Console.Read();
        }
    }
}
