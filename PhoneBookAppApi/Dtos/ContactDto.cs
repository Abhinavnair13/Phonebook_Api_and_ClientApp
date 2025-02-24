﻿using System.ComponentModel.DataAnnotations;

namespace PhoneBookAppApi.Dtos
{
    public class ContactDto
    {
        public int contactId { get; set; }

        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Company { get; set; }

        [Required]
        [StringLength(15)]
        public string ContactNumber { get; set; }

        public string? FileName { get; set; }
    }
}
