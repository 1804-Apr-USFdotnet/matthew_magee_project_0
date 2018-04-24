using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Library.Controllers;
using Library.Models;

namespace RestaurantProject0
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var whatever = new RestaurantRepository();
            var myArray = whatever.TopThreeRestaurants();
            int i = 0;
            Console.WriteLine(myArray);
            //foreach (var year in myArray)
            //{
            //    Console.WriteLine(year.Restaurant.name);
            //    foreach (var s in year.Restaurant.reviews)
            //    {
            //        Console.WriteLine(s.review);
            //    }
                
            //}
            Console.Read();
        }
    }
}
