using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Controllers;

namespace Library.Helpers
{
    public class UI
    {
        public string input { get; set; }
        public string searchString { get; set; }

        public RestaurantRepository restaurantProgram { get; set; }

        public UI()
        {
            restaurantProgram = new RestaurantRepository();
        }

        public void InitialStartup()
        {
            input= "";
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
                        "7. Display top 3 restaurants by rating"+
                        "Exit the program at any time by entering 'quit'"

                    );

                input = Console.ReadLine();

                HandleInput();
            }

            Console.WriteLine("Goodbye");
            System.Environment.Exit(1);
        }

        private void HandleInput()
        {
            switch (input.ToLower())
            {
                case "1":
                    restaurantProgram.GetAll();
                    break;
                case "2":
                    restaurantProgram.GetAllByRating();
                    break;
                case "3":
                    restaurantProgram.GetAllByName();
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
                    restaurantProgram.TopThreeRestaurants();
                    break;
                default:
                    Console.WriteLine("Sorry your input was not recognized.  Please try again.");
                    InitialStartup();
                    break;

            }
        }

        public void SearchRestaurants()
        {
            Console.WriteLine("Please enter the information you would like to search for.");
            searchString = Console.ReadLine().ToLower();
            restaurantProgram.Search(searchString);

        }

        public void GetDetails()
        {
            Console.WriteLine("Please enter the restaurant you would like details on.");
            searchString = Console.ReadLine().ToLower();
            restaurantProgram.Details(searchString);
        }

        public void GetReviews()
        {
            Console.WriteLine("Please enter the restaurant you would like to see reviews");
            searchString = Console.ReadLine().ToLower();
            restaurantProgram.Reviews(searchString);
        }
    }
}

