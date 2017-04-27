using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using SoftUniBook.Models;

namespace SoftUniBook.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private ApplicationDbContext db;

        public UsersController()
        {
            this.db = new ApplicationDbContext();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser user = db.Users.Find(id);

            if (user == null)
            {
                return HttpNotFound();
            }

            var model = new ApplicationUser();
            model.Age = user.Age;
            model.Gender = user.Gender;
            model.City = user.City;
            model.AdditionalInformation = user.AdditionalInformation;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ApplicationUser model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.Find(model.Id);
                user.Age = model.Age;
                user.City = model.City;
                user.Gender = model.Gender;
                user.AdditionalInformation = model.AdditionalInformation;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Profile");
            }

            return View(model);
        }
    }
}