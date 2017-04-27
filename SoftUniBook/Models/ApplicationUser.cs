using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace SoftUniBook.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        public string ProfileImagePath { get; set; }

        public string City { get; set; }

        public ICollection<Post> Posts { get; set; }

        public int Age { get; set; }

        public string AdditionalInformation { get; set; }

        public string Gender { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            return userIdentity;
        }
    }
}