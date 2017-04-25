

using SoftUniBook.Migrations;
using SoftUniBook.Models;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(SoftUniBook.Startup))]
namespace SoftUniBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            ConfigureAuth(app);
        }
    }
}
