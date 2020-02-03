using System;
using System.Collections.Generic;
using System.Data.Entity;
using DR874115_MIS4200.Models;
using System.Linq;
using System.Web;

namespace DR874115_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a constructor and is called
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<customer> Customers { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }

        public System.Data.Entity.DbSet<DR874115_MIS4200.Models.Products> Products { get; set; }
    }
}