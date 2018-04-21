using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Data;
using Data.Models;

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
                Console.WriteLine(
                    item.Name + "\n" + item.Address + "\n" + item.ZipCode + "\n" + item.PhoneNumber + "\n");
            }

            ProgramLoop();
        }

        public void SearchRestaruants()
        {
        }

        public void RestaurantDetails()
        {
            string input = "";
            Console.WriteLine("Enter Restaurant Number To View Details Or Enter 'back' to go back");
            while (input.ToLower() != "back")
            {
                input = Console.ReadLine().Trim().ToLower();
                try
                {
                    if (input == "quit")
                    {
                        System.Environment.Exit(1);
                    }

                    else if (int.Parse(input) < 21 && int.Parse(input) > 0)
                    {
                        var restaurants = _context.Restaurants.ToList();
                        var reviews = _context.Reviews.ToList();
                        var resultRestaurant = restaurants.Where(s => s.Id == int.Parse(input));
                        var resultReview = reviews.Where(r => r.RestaurantId == int.Parse(input));
                        foreach (var r in resultRestaurant)
                        {
                            Console.WriteLine("Name: " + r.Name);
                            Console.WriteLine("Address: " + r.Address);
                            Console.WriteLine("Zip Code: " + r.ZipCode);
                            Console.WriteLine("Phone Number: " + r.PhoneNumber);
                        }

                        foreach (var item in resultReview)
                        {
                            Console.WriteLine("Reviews: " + item.ReviewMessage);
                            Console.WriteLine("Ratings: " + item.Rating);
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("We are sorry, your response was not understood.  Please try again.");
                    ProgramLoop();
                }

                
            }
            ProgramLoop();
        }

        public void RestaurantReviews()
        {
        }

        public void TopRestaurantsByRating()
        {
            Console.WriteLine("The Top 3 Restaurants By Rating Are: ");
            var query = (from p in _context.Restaurants
                    join c in _context.Reviews on p.Id equals c.RestaurantId into g
                    select new {Restuarant = p.Name, Average = g.Average(x => (float?) x.Rating)})
                .OrderByDescending(x => x.Average)
                .Take(3);

            foreach (var item in query)
            {
                if (item.Average != null)
                {
                    Console.WriteLine("Name: {0}  Rating: {1}", item.Restuarant, item.Average);
                }
            }

            ProgramLoop();
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
                        TopRestaurantsByRating();
                        break;
                    case "3":
                        RestaurantDetails();
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