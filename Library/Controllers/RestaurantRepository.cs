using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using Library.Helpers;
using Library.Models;
using Newtonsoft.Json;

namespace Library.Controllers
{
    public class RestaurantRepository : IRepository<RootObject>
    {
        public IList<RootObject> myArray { get; set; }

        public RestaurantRepository()
        {
            var data = new DataHelper();
            myArray = data.deserialize();
        }

        public IEnumerable<RootObject> GetAll()
        {         
            return myArray;
        }

        public IEnumerable<RootObject> GetAllByRating()
        {
            return myArray.OrderByDescending(rest => rest.Restaurant.averageRating());
        }

        public IEnumerable<RootObject> GetAllByName()
        {
            return myArray.OrderByDescending(rest => rest.Restaurant.name);
        }

        public IEnumerable<RootObject> Search(string searchString)
        {
            var results = myArray.Where(r => r.Restaurant
                                              .ToString()
                                              .ToLower()
                                              .Contains(searchString
                                              .ToLower()));
            return results;
        }

        public string Details(string restaurantName)
        {
            var result = myArray.FirstOrDefault(r => r.Restaurant
                .ToString()
                .ToLower()
                .Contains(restaurantName
                    .ToLower()));

            return result.Restaurant.ToString();
        }

        public string Reviews(string restaurantName)
        {
            var result = myArray.FirstOrDefault(r => r.Restaurant
                .ToString()
                .ToLower()
                .Contains(restaurantName
                    .ToLower()));

            string reviewBuilder = "";
            foreach (var i in result.Restaurant.reviews)
            {
                reviewBuilder += "Username: " + i.username + " Review: " + i.review + "\n";
            }

            return reviewBuilder;
        }

        public string TopThreeRestaurants()
        {
            var query = myArray.OrderByDescending(rest => rest.Restaurant.averageRating()).Take(3);
            string restaurantBuilder = "";
            foreach (var item in query)
            {
                restaurantBuilder += item.Restaurant.ToString() + "\n";
            }

            return restaurantBuilder;
        }


        
    }
}
