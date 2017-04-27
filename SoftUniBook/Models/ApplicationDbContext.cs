using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SoftUniBook.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        //спри бе, тука трябва да дадеш ИД-то на ролята на админа, и ИД-то на юсера glei 
    }
}