using System;
using System.Linq;
using Library.Controllers;
using NLog;

namespace Library.Helpers
{
    public class RestaurantController
    {
        public string input { get; set; }
        public string searchString { get; set; }

        public RestaurantRepository restaurantProgram { get; set; }
        
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public RestaurantController()
        {
            restaurantProgram = new RestaurantRepository();
            input = "";
        }

        public void InitialStartup()
        {
            
            while (input != "quit")
            {
                Console.WriteLine(
                        "Welcome! Please select one of the options below by entering the corresponding item number.\n"+
                        "1. Get list of All Restaurants\n" +
                        "2. Get list of All Restaurants by rating\n"+
                        "3. Get list of All Restaurants by name\n"+
                        "4. Search for restaurants\n" +
                        "5. Get details of a restaurant\n"+
                        "6. Display reviews of a restaurant\n"+
                        "7. Display top 3 restaurants by rating\n"+
                        "Exit the program at any time by entering 'quit'"

                    );

                input = Console.ReadLine();

                HandleInput();
            }

            Console.WriteLine("Goodbye");
            Environment.Exit(1);
        }

        private void HandleInput()
        {
            switch (input.ToLower())
            {
                case "1":
                    GetAllRestaurants();
                    break;
                case "2":
                    GetAllRating();
                    break;
                case "3":
                    GetAllName();
                    break;
                case "4":
                    SearchRestaurants();
                    break;
                case "5":
                    GetDetails();
                    break;
                case "6":
                    GetReviews();
                    break;
                case "7":
                    GetTopThree();
                    break;
                default:
                    Console.WriteLine("Sorry your input was not recognized.  Please try again.");
                    InitialStartup();
                    break;

            }
        }

        public void GetAllRestaurants()
        {
            var result = restaurantProgram.GetAll();
            
                foreach (var item in result)
                {
                    Console.WriteLine(item.Restaurant.ToString());
                }
            
            
        }

        public void GetAllRating()
        {
            var result = restaurantProgram.GetAllByRating();
            foreach (var item in result)
            {
                Console.WriteLine(item.Restaurant.ToString());
            }
        }

        public void GetAllName()
        {
            var result = restaurantProgram.GetAllByName();
            foreach (var item in result)
            {
                Console.WriteLine(item.Restaurant.ToString());
            }
        }

        public void SearchRestaurants()
        {
            Console.WriteLine("Please enter the information you would like to search for.");
            searchString = Console.ReadLine().ToLower();
            var result = restaurantProgram.Search(searchString);
            if (!result.Any())
            { 
                logger.Warn("Unable to find a matching result.  Please try again.");
            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item.Restaurant.ToString());
                }
            }
            

        }

        public void GetDetails()
        {
            Console.WriteLine("Please enter the restaurant you would like details on.");
            searchString = Console.ReadLine().ToLower();
            var result = restaurantProgram.Details(searchString);
            if (String.IsNullOrEmpty(result))
            {
                logger.Warn("No Results Found. Please Try Again.");
            }
            else
            {
                Console.WriteLine(result);
            }
            
        }

        public void GetReviews()
        {
            Console.WriteLine("Please enter the restaurant you would like to see reviews");
            searchString = Console.ReadLine().ToLower();
            var result = restaurantProgram.Reviews(searchString);
            if (String.IsNullOrEmpty(result))
            {
                
                logger.Warn("Unable to find a matching result.  Please try again.");
            }
            else
            {
                Console.WriteLine(result);
            }

        }   

        public void GetTopThree()
        {
            var result = restaurantProgram.TopThreeRestaurants();
            Console.WriteLine(result);
            
        }
    }
}

