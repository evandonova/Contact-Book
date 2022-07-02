using System.ComponentModel.DataAnnotations;

namespace Contact_Book.Data.Entities
{
    using static DataConstants;
    public class Contact
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(MaxFirstNameLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(MaxLastNameLength)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(MaxEmailLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(MaxPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [MaxLength(MaxCommentsLength)]
        public string Comments { get; set; }

        [Required]
        public string OwnerId { get; init; }
        public User Owner { get; init; }
    }
}
