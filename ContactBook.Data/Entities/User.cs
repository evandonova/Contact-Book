using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ContactBook.Data.Entities
{
    using static DataConstants;
    public class User : IdentityUser
    {
        [MaxLength(MaxFirstNameLength)]
        public string FirstName { get; init; }

        [MaxLength(MaxLastNameLength)]
        public string LastName { get; init; }

        [MaxLength(MaxPhoneNumberLength)]
        public string PhoneNumber { get; init; }
    }
}
