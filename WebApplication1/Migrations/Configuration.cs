namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.EFContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Users.AddOrUpdate(u => u.Id, new Models.User
            {
                Id = 1,
                Name = "q",
                Email = "q@q.com",
                Password = "1"
            });
            context.Users.AddOrUpdate(u => u.Id, new Models.User
            {
                Id = 1,
                Name = "q",
                Email = "q@q.com",
                Password = "1"
            });
        }
    }
}
