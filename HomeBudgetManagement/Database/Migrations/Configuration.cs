using Database.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Database.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<HomeManagementDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeManagementDbContext context)
        {
            context.Categories.AddOrUpdate(new Category() { Id = 1, Name = "Zakupy", Limit = 1000 });
            context.Categories.AddOrUpdate(new Category() { Id = 2, Name = "Samochód", Limit = 1000 });
            context.Categories.AddOrUpdate(new Category() { Id = 3, Name = "Wycieczki", Limit = 1000 });
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
