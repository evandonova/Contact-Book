# Contact Book
"**Contact Book**" is an ASP.NET Core Web app + API for contacts.

* It has one seeded user and three seeded contacts.
* Default user credentials: ```guest@mail.com``` / ```guest```
* Restrictions:
  - You cannot create two contacts with the same phone number.
  - You can view only the contacts you created.
  - You cannot edit or delete contacts of another user.
  - Each created contact should have first name, last name, email and phone number. Comments are optional.
  - Phone number should have lenght between 10 and 12 characters (13 is invalid) and with a correct format (without spaces)

## Contact Book Web App

The ASP.NET Core app "Contact Book" is an app for creating and storing contacts.
* Technologies: C#, ASP.NET Core, Entity Framework Core, ASP.NET Core Identity
* The app has the following pages:
   - Home page for non-logged-in users (all contacts count + login page link + register page link): `/`
   - Home page for loggeed-in users (navigation bar + all contacts count + menu + user contact info if logged-in): `/`
   - View all contacts page of logged-in user: `/Contacts/All`
   - Create a new contact page (first name + last name + email + phone number + comments): `/Contacts/Create`
   - Edit contact page: `/Contacts/Edit/:id`
   - Delete contact page: `/Contacts/Delete/:id`
   - Search contacts page: `/Contacts/Search`
 
### Screenshots
<kbd><img src="https://user-images.githubusercontent.com/69080997/189330511-a5574375-5c9d-4fdc-ae49-9e93bdf49644.png" width="600"></kbd>
<kbd><img src="https://user-images.githubusercontent.com/69080997/189331028-a74f770f-b6ae-4f89-96de-d704edc136d6.png" width="600"></kbd>
<kbd><img src="https://user-images.githubusercontent.com/69080997/189332306-7d64af3a-34fe-4d82-9413-725defb7f2d4.png" width="600"></kbd>
<kbd><img src="https://user-images.githubusercontent.com/69080997/189332078-11febd4d-381c-453f-9623-30db1c4cf010.png" width="600"></kbd>

## Contact Book RESTful API

The following endpoints are supported:
 - `GET /`, `GET /api`, `GET /swagger` - show Swagger page
 - `GET /api/users/myData` - return data of the logged-in user
 - `GET /api/contacts` - list all user contacts of logged-in user
 - `GET /api/contacts/count` - return contacts count
 - `GET /api/contacts/search/:keyword` - list all user contacts of logged-in user matching a given keyword
 - `POST /api/users/login` - logs in an existing user (send a JSON object in the request body, holding all fields, e.g. `{"email": "guest@mail.com", "password": "guest"}`)
 - `POST /api/users/register` - registers a new user (send a JSON object in the request body, holding all fields, e.g. `{"email": "user@example.com", "firstName": "Name", "lastName": "LastName", "phoneNumber": "+192088877744", "password": "pass123", "confirmPassword": "pass123"}`)
 - `POST /api/contacts/create` - create a new contact (post a JSON object in the request body, e.g. `{"first name": "Johnny", "last name": "Depp", "email": "j.depp@mail.com", "phone number": "+12298015369", "comments": "An American actor, producer, and musician. Best in 'Pirates of the Caribbean'"}`)
 - `PUT /api/contacts/:id` - edit contact by `id` (send a JSON object in the request body, holding all fields, e.g. `{"first name": "Johnny", "last name": "Depp", "email": "j.depp@mail.com", "phone number": "+12298015369", "comments": "An American actor, producer, and musician. Best in 'Pirates of the Caribbean'"}`)
 - `PATCH /api/contacts/:id` - partially edit contact by `id` (send a JSON object in the request body, holding the fields to modify, e.g. `{"email": "johnny.depp@mail.com", "phone number": "+12298015369"}`)
 - `DELETE /api/contacts/:id` - delete contact by `id`
 
### Screenshots
<kbd><img src="https://user-images.githubusercontent.com/69080997/189333217-2b914dd7-5483-4e05-aa87-991ab550d38e.png" width="600"></kbd>
<kbd><img src="https://user-images.githubusercontent.com/69080997/189333519-6dbaee14-1d4d-41a3-8e0f-7c13bf7f1b16.png" width="600"></kbd>
<kbd><img src="https://user-images.githubusercontent.com/69080997/189334069-25d4f065-dd3f-45fd-bee9-410960f346ed.png" width="600"></kbd>

 
