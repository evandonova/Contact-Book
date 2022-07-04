using Contact_Book.Data;
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
                var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                homeModel.UserContactsCount = this.dbContext.Contacts
                    .Where(c => c.OwnerId == currentUserId).Count();
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