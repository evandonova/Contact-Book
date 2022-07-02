using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Contact_Book.Data.Entities
{
    using static DataConstants;
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(MaxFirstNameLength)]
        public string FirstName { get; init; }

        [Required]
        [MaxLength(MaxLastNameLength)]
        public string LastName { get; init; }

        [Required]
        [MaxLength(MaxPhoneNumberLength)]
        public string PhoneNumber { get; init; }
    }
}
