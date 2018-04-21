using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Library
{
    public class RestaurantController
    {
        
        private ApplicationDbContext _context;

        public RestaurantController()
        {
            _context = new ApplicationDbContext();
            
        }
        public void GetListOfRestaurants()
        {
            
            var restaurants = _context.Restaurants.ToList();
            foreach (var item in restaurants)
            {
                Console.WriteLine(item.Name + "\n" + item.Address + "\n" + item.ZipCode + "\n" + item.PhoneNumber + "\n");
            }
            ProgramLoop();
        }

        public void SearchRestaruants()
        {

        }

        public void RestaurantDetails()
        {

        }

        public void RestaurantReviews()
        {

        }

        public void TopRestaurantsByRating()
        {
            //var restaurants = _context.Restaurants.Include(r => r.);

        }


        public void ProgramLoop()
        {
            string input = "";
            Console.WriteLine("Welcome! This program allows you to view");
            Console.WriteLine("Restaurants, their ratings, and reviews.");
            Console.WriteLine("Type 'quit' at any time to exit the program");
            Console.WriteLine("Type 1 for a list of all restaurants");
            Console.WriteLine("Type 2 to display top 3 restaurants by ratings");
            Console.WriteLine("Type 3 to search for a specific restaurant");
            while (input.ToLower() != "quit")
            {
                
               input = Console.ReadLine();
                switch (input.Trim().ToLower()) 
                {
                    case "1":
                        GetListOfRestaurants();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "quit":
                        input = "quit";
                        break;
                    default:
                        Console.WriteLine("Sorry, your input was not recognized.  Please try again.");
                        ProgramLoop();
                        break;

                }
            }

            Console.WriteLine("Goodbye!");
            System.Environment.Exit(1);
        }
    }
}
