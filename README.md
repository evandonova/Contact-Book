# Contact Book
"Contact Book" is an ASP.NET Core Web app for contacts.

## Contact Book Web App

The ASP.NET Core app "Contact Book" is an app for creating and storing contacts.
* Technologies: C#, ASP.NET Core, Entity Framework Core, ASP.NET Core Identity
* The app supports the following operations:
 - Home page (view all contacts count + menu + user contact info if logged-in): `/`
 - View logged-in user's contacts: `/Contacts/All`
 - Create a new contact (first name + last name + email + phone number + comments): `/Contacts/Create`
 - Edit contact: `/Contacts/Edit/:id`
 - Delete contact: `/Contacts/Delete/:id`
 - Search contact page: `/Contacts/Search`
