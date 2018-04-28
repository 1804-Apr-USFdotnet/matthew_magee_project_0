using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using NLog;

namespace Library
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
                        "\nWelcome! Please select one of the options below by entering the corresponding item number.\n" +
                        "1. Get list of All Restaurants\n" +
                        "2. Get list of All Restaurants by rating\n" +
                        "3. Get list of All Restaurants by name\n" +
                        "4. Search for restaurants\n" +
                        "5. Get details of a restaurant\n" +
                        "6. Display reviews of a restaurant\n" +
                        "7. Display top 3 restaurants by rating\n" +
                        "8. Update a restaurant\n" +
                        "9. Delete a restaurant\n" +
                        "10. Insert a new restaurant\n" +
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
                case "8":
                    Update();
                    break;
                case "9":
                    Delete();
                    break;
                case "10":
                    Insert();
                    break;
                default:
                    logger.Warn("Sorry your input was not recognized.  Please try again.");
                    InitialStartup();
                    break;

            }
        }

        public void GetAllRestaurants()
        {
            var result = restaurantProgram.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }


        }

        public void GetAllRating()
        {
            var result = restaurantProgram.GetAllByRating();
            Console.WriteLine(result);
        }
    
        public void GetAllName()
        {
            var result = restaurantProgram.GetAllByName();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void SearchRestaurants()
        {
            Console.WriteLine("Please enter the information you would like to search for.");
            searchString = Console.ReadLine().ToLower();
            try
            {
                var result = restaurantProgram.Search(searchString);
                Console.WriteLine(result.ToString());
            }
            catch (Exception e)
            {
                logger.Warn("Unable to find any Restaurants matching that search.  Please try again.");
            }
           


        }

        public void GetDetails()
        {
            Console.WriteLine("Please enter the restaurant you would like details on.");
            searchString = Console.ReadLine().ToLower();
            var result = restaurantProgram.Details(searchString);
            if (String.IsNullOrEmpty(result))
            {
                logger.Warn("Unable to find those restaurant details.  Please try again.");
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
            try
            {
                
                var result = restaurantProgram.Reviews(searchString);
                if (String.IsNullOrEmpty(result))
                {
                    logger.Warn("Unable to find that restaurant.  Please try again.");
                }
                else
                {
                    Console.WriteLine(result);
                }
                
            }
            catch (Exception e)
            {
                logger.Warn("Unable to find that restaurant.  Please try again.");
            }
        }

        public void GetTopThree()
        {
            var result = restaurantProgram.TopThreeRestaurants();
            Console.WriteLine(result);

        }

        public void Update()
        {
            GetAllRestaurants();
            
            int id;
            while (true)
            {
                Console.WriteLine("Please enter the Id number you would like to update");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Please enter the name you would like to change the restaurant to.");
                    searchString = Console.ReadLine();
                    restaurantProgram.Update(id, searchString);
                    break;
                }
               logger.Warn("Please enter a valid ID!");
            }
            GetAllRestaurants();
        }

        public void Delete()
        {
            GetAllRestaurants();

            int id;
            while (true)
            {
                Console.WriteLine("Please enter the Id number you would like to delete");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    
                    restaurantProgram.Delete(id);
                    break;
                }
                logger.Warn("Please enter a valid ID!");
            }
            GetAllRestaurants();

        }

        public void Insert()
        {
            string name, address, phoneNumber;
            int zipCode;
            Console.WriteLine("Please enter a restaurant name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter an address.");
            address = Console.ReadLine();
            Console.WriteLine("Please enter a phone number");
            phoneNumber = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Please enter a zip code.");
                if (int.TryParse(Console.ReadLine(), out zipCode))
                {

                    restaurantProgram.Insert(name, address, zipCode, phoneNumber);
                    break;
                }
                logger.Warn("Please enter a valid zip code!");
            }

            GetAllRestaurants();
        }
    }
}
