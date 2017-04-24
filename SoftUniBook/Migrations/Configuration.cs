namespace Blog.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Blog.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
             context.Categories.AddOrUpdate(
               p => p.Title,
               new Category[]
               {
                   new Category{ Title = "Php" },
                   new Category{ Title = "C#" },
                   new Category{ Title = "Java" },
                   new Category{ Title = "JavaScript" }
               } 
             );
             
        }
    }
}
