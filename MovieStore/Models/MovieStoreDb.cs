using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieStore.Models
{
    public class MovieStoreDb : DbContext
    {
        public MovieStoreDb() : base ("MovieStoreConnection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderRow> OrderRows { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}