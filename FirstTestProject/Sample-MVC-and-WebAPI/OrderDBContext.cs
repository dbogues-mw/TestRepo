using Sample_MVC_and_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sample_MVC_and_WebAPI
{
    public class OrderDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }


    }
}