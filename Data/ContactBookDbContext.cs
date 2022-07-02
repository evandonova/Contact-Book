using Contact_Book.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contact_Book.Data
{
    public class ContactBookDbContext : IdentityDbContext<User>
    {
        public ContactBookDbContext(DbContextOptions<ContactBookDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}