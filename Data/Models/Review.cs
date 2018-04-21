using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string ReviewMessage { get; set; }
        public float Rating { get; set; }
        public string Username { get; set; }
    }
}
