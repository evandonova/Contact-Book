using Contact_Book.Data;
using Contact_Book.Data.Entities;
using Contact_Book.Infrastructure;
using Contact_Book.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Book.Controllers
{
    [Authorize]
    public class ContactsController : Controller
    {
        private readonly ContactBookDbContext dbContext;
        public ContactsController(ContactBookDbContext dbContext) 
            => this.dbContext = dbContext;

        public IActionResult All()
        {
            var contacts = this.dbContext.Contacts
                .Where(c => c.OwnerId == this.User.Id())
                .Select(c => new ContactViewModel()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,
                    Comments = c.Comments
                })
                .ToList();

            return View(contacts);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(ContactFormModel contactModel)
        {
            var userContacts = this.dbContext.Contacts.Where(c => c.OwnerId == this.User.Id());
            if (userContacts.Any(c => c.PhoneNumber == contactModel.PhoneNumber))
            {
                this.ModelState.AddModelError(nameof(contactModel.PhoneNumber),
                    "You already have a contact with the given phone number!");
            }

            if (!ModelState.IsValid)
            {
                return View(contactModel);
            }

            var contact = new Contact()
            {
                FirstName = contactModel.FirstName,
                LastName = contactModel.LastName,
                PhoneNumber = contactModel.PhoneNumber,
                Email = contactModel.Email,
                Comments = contactModel.Comments == null ? String.Empty : contactModel.Comments,
                DateCreated = DateTime.Now,
                OwnerId = this.User.Id()
            };
            this.dbContext.Contacts.Add(contact);
            this.dbContext.SaveChanges();

            return RedirectToAction(nameof(All));
        }
    }
}
