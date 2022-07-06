﻿using System.ComponentModel.DataAnnotations;
using Contact_Book.Data;

namespace Contact_Book.Models
{
    using static DataConstants;
    public class ContactFormModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(MaxFirstNameLength, MinimumLength = MinFirstNameLength, 
            ErrorMessage = "First name should be at least {2} characters long.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(MaxLastNameLength, MinimumLength = MinLastNameLength,
            ErrorMessage = "Last name should be at least {2} characters long.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(MaxPhoneNumberLength, MinimumLength = MinPhoneNumberLength,
            ErrorMessage = "Phone number should be between {1} and {2} characters long.")]
        [RegularExpression(PhoneNumberRegex, ErrorMessage = "Enter a valid phone number (without spaces).")]
        public string PhoneNumber { get; set; }

        [StringLength(MaxCommentsLength)]
        public string Comments { get; set; }
    }
}