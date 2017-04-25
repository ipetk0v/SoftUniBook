namespace SoftUniBook.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SoftUniBook.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;          
        }

        protected override void Seed(SoftUniBook.Models.ApplicationDbContext context)
        {
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
