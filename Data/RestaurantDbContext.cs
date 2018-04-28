using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data
{
    public class RestaurantDbContext : DbContext
    {
            public DbSet<Restaurants> Restaurants { get; set; }
            public DbSet<Review> Reviews { get; set; }

        public RestaurantDbContext() : base("name = RestaurantDB")
        {

        }
    }
}
