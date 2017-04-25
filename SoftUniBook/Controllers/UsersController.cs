using SoftUniBook.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Data.Entity;

namespace SoftUniBook.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext db;
        public UsersController()
        {
            this.db = new ApplicationDbContext();
        }

        
    }
}