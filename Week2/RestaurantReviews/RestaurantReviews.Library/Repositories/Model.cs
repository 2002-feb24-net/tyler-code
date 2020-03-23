using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Library.Models;

namespace RestaurantReviews.Library.Models
{
    class Model : DbContext
    {
        private const string V = "Data Source../../restruant.db)";

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Restaurant> Review { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object p = optionsBuilder.UseSqlite(V);
        }
    }
}
