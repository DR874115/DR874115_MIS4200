using System;
using System.Collections.Generic;
using System.Data.Entity;
using DR874115_MIS4200.Models;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DR874115_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, DR874115_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
            // this method is a constructor and is called
        }
        //public DbSet<Orders> Orders { get; set; }
       // public DbSet<customer> Customers { get; set; }
        //public DbSet<Products> Products { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //SD 2 
        public DbSet<Pets> Pets { get; set; }
        public DbSet<Owners> Owners { get; set; }
        public DbSet<PetDetails> PetDetails { get; set; }

        // public System.Data.Entity.DbSet<DR874115_MIS4200.Models.Products> Products { get; set; }

        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}