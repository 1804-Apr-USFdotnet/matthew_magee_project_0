using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Models
{
    public class Restaurant
    {
        public string name { get; set; }
        public string location { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }
        public string phoneNumber { get; set; }
        public List<double> ratings { get; set; }
        public List<Review> reviews { get; set; }

        public override string ToString()
        {
            return name + " " + location + " " + state + " " + zipCode + " " + phoneNumber + " Average Rating: " +
                   averageRating();
        }

        public double averageRating()
        {
            var avg = ratings.Average();
            var avgTwoPlaces = Math.Round(avg, 2);
            return avgTwoPlaces;
        }
    }
}
