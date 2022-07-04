﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Contact_Book.Data.Entities;

namespace Contact_Book.Data
{
    public class ContactBookDbContext : IdentityDbContext<User>
    {
        private bool seedDb = true;
        private User guestUser;

        public ContactBookDbContext(DbContextOptions<ContactBookDbContext> options, bool seedDb = true)
            : base(options)
        {
            this.seedDb = seedDb;
            this.Database.Migrate();
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (seedDb)
            {
                SeedUser();
                builder.Entity<User>()
                    .HasData(this.guestUser);

                builder
                    .Entity<Contact>()
                    .HasData(new Contact()
                    {
                        Id = 1,
                        FirstName = "Steve",
                        LastName = "Jobs",
                        Email = "steve@apple.com",
                        PhoneNumber = "+180023456789",
                        DateCreated = DateTime.Now.AddDays(-320),
                        Comments = "Steven Jobs was an American business magnate, industrial designer, investor, and media proprietor.",
                        OwnerId = this.guestUser.Id
                    },
                    new Contact()
                    {
                        Id = 2,
                        FirstName = "Michael",
                        LastName = "Jackson",
                        Email = "michael@jackson.com",
                        PhoneNumber = "+190088877744",
                        DateCreated = DateTime.Now.AddDays(-500),
                        Comments = "Michael Joseph Jackson was an American singer, songwriter, and dancer.",
                        OwnerId = this.guestUser.Id
                    },
                    new Contact()
                    {
                        Id = 3,
                        FirstName = "Albert",
                        LastName = "Einstein",
                        Email = "albert.e@uzh.ch",
                        PhoneNumber = "+41446344901",
                        DateCreated = DateTime.Now.AddDays(-1000),
                        Comments = "Albert Einstein was a German-born theoretical physicist, universally acknowledged to be one of the two greatest physicists of all time, the other being Isaac Newton.",
                        OwnerId = this.guestUser.Id
                    });
            }

            base.OnModelCreating(builder);
        }

        private void SeedUser()
        {
            var hasher = new PasswordHasher<User>();

            this.guestUser = new User()
            {
                Id = "guest856-c198-4129-b3f3-b893d8395082",
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM",
                PhoneNumber = "+359000000000",
                FirstName = "Guest",
                LastName = "User",
            };

            this.guestUser.PasswordHash = hasher.HashPassword(this.guestUser, "guest");
        }
    }
}