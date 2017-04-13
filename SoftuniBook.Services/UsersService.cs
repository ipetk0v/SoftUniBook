using Blog.Models;
using SoftUniBook.Models.ViewModels.Users;
using System.Collections.Generic;

namespace SoftuniBook.Services
{
    public class UsersService
    {
        private ApplicationDbContext db;
        public UsersService()
        {
            this.db = new ApplicationDbContext();
        }

        public IEnumerable<PostVm> GetUserPost()
        {
        //    IEnumerable<PostVm>
            return null;
        }

    }
}
