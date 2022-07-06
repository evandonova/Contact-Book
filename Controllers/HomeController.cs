using Contact_Book.Data;
using Contact_Book.Infrastructure;
using Contact_Book.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace Contact_Book.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactBookDbContext dbContext;

        public HomeController(ContactBookDbContext context)
            => this.dbContext = context;

        public IActionResult Index()
        {
            var homeModel = new HomeViewModel();
            homeModel.AllContactsCount = this.dbContext.Contacts.Count();

            if (this.User.Identity.IsAuthenticated)
            {
                homeModel.UserContactsCount = this.dbContext.Contacts
                    .Where(c => c.OwnerId == this.User.Id()).Count();

                var currentUser = this.dbContext.Users.Find(this.User.Id());
                homeModel.UserFullName = currentUser.FirstName + " " + currentUser.LastName;

                homeModel.UserContact = new ContactViewModel()
                {
                    FirstName = currentUser.FirstName,
                    LastName = currentUser.LastName,
                    Email = currentUser.Email,
                    PhoneNumber = currentUser.PhoneNumber
                };
            }

            return View(homeModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}