namespace SoftUniBook.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
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
            
        }
    }
}
