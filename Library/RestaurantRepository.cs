using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;
using Data.Models;
using Library.Helpers;
using Library.Interfaces;

namespace Library
{
   public class RestaurantRepository : IRepository<Restaurants>
    {

        public RestaurantDbContext _context { get; set; }
        private List<Restaurants> restaurants;
        private List<Review> reviews;

        public RestaurantRepository()
        {
            var data = new DataHelper();
            _context = new RestaurantDbContext();
            restaurants = _context.Restaurants.ToList();
            reviews = _context.Reviews.ToList();
        }

        public List<Restaurants> GetAll()
        {

            return restaurants;
        }

        public string GetAllByRating()
        {
            var query = from Reviews in _context.Reviews
                join Restaurants in _context.Restaurants on new {Id = Reviews.Restaurants.Id} equals new
                {
                    Id = Restaurants.Id
                }
                group new {Reviews, Restaurants} by new
                {
                    Reviews.Restaurants,
                    Restaurants.Name,
                    Restaurants.Id
                }
                into g
                orderby
                    g.Average(p => p.Reviews.Rating) descending
                select new
                {
                    Average = g.Average(p => p.Reviews.Rating),
                    g.Key.Name,
                    g.Key.Id
                };
            string stringBuilder = "";
            foreach (var item in query)
            {
                stringBuilder += item.Id + " " + item.Name + "  Rating:" + Math.Round(item.Average) +"\n";
            }

            return stringBuilder;


        }

        public List<Restaurants> GetAllByName()
        {
            return _context.Restaurants.OrderBy(n => n.Name).ToList();
        }

        public Restaurants Search(string searchString)
        {
            return restaurants.FirstOrDefault(n => n.Name.ToLower().Contains(searchString.ToLower()));
        }

        public string Details(string restaurantName)
        {
            var result = restaurants.FirstOrDefault(r => r.Name.ToLower()
                .Contains(restaurantName.ToLower()));
            if (result == null)
            {
                return "";
            }

            return result.ToString();
        }
 
        public string Reviews(string restaurantName)
        {
            var query = from Reviews in _context.Reviews
                join Restaurants in _context.Restaurants on new {Id = Reviews.Restaurants.Id} equals new
                {
                    Id = Restaurants.Id
                }
                where
                    Restaurants.Name.Contains(restaurantName)
                select new
                {
                    Restaurants.Name,
                    Reviews.Rating,
                    Reviews.ReviewMessage
                };

            string stringBuilder = "";
            foreach (var item in query)
            {
                stringBuilder += item.Name + " " + item.ReviewMessage + "  Rating:" + Math.Round(item.Rating) + "\n";
            }

            return stringBuilder;

        }

        public string TopThreeRestaurants()
        {
            var query =  (from Reviews in _context.Reviews
                join Restaurants in _context.Restaurants on new {Id = Reviews.Restaurants.Id} equals new
                {
                    Id = Restaurants.Id
                }
                group new {Reviews, Restaurants} by new
                {
                    Reviews.Restaurants,
                    Restaurants.Name,
                    Restaurants.Id
                }
                into g
                orderby
                    g.Average(p => p.Reviews.Rating) descending
                select new
                {
                    Average = g.Average(p => p.Reviews.Rating),
                    g.Key.Name,
                    g.Key.Id
                }).Take(3);

            string stringBuilder = "";
            foreach (var item in query)
            {
                stringBuilder += item.Name + " "  + "  Rating:" + Math.Round(item.Average) + "\n";
            }

            return stringBuilder;


        }

        public void Update(int restaurantId, string name)
        {
            var result = _context.Restaurants.SingleOrDefault(r => r.Id == restaurantId);
            if (result != null)
            {
                result.Name = name;
                _context.SaveChanges();
            }
        }

        public void Delete(int restaurantId)
        {
            _context.Reviews.RemoveRange(_context.Reviews.Where(x => x.Restaurants.Id == restaurantId));
            _context.Restaurants.RemoveRange(_context.Restaurants.Where(x => x.Id == restaurantId));
            _context.SaveChanges();
        }

        public void Insert(string name, string address, int zipcode, string phoneNumebr)
        {
            var rest = _context.Set<Restaurants>();
            rest.Add(new Restaurants() {Name = name,Address = address,ZipCode = zipcode,PhoneNumber = phoneNumebr});

            _context.SaveChanges();
        }
    }
}
