﻿using System.ComponentModel.DataAnnotations;

namespace MyLeasingHouse.Common.Models
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
