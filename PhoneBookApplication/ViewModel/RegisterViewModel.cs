﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhoneBookApplication.ViewModel
{
    public class RegisterViewModel
    {
        public int UserId { get; set; }
        
        [Required(ErrorMessage = "First name is required.")]

        [StringLength(15)]
        [DisplayName("First Name")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]

        [StringLength(15)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }


        [StringLength(15)]
        [DisplayName("Login Id")]

        [Required(ErrorMessage = "Login id is required.")]

        public string LoginId { get; set; }

        [Required(ErrorMessage = "Email address is required.")]

        [StringLength(50)]

        [EmailAddress]
        [DisplayName("Email Address")]

        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email format.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]

        [StringLength(15)]

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Contact Number")]

        [RegularExpression(@"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$", ErrorMessage = "Invalid contact number.")]

        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "File is required")]
        public IFormFile File { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",

        ErrorMessage = "The password must be at least 8 characters long and contain at least 1 uppercase letter, 1 number, and 1 special character.")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]

        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]

        public string ConfirmPassword { get; set; }


    }
}
