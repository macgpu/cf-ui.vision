using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OCRReaderMVCWeb.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage="Your contact name is required")]
        public string ContactName { get; set; }

        [Required(ErrorMessage="Your email is required")]
        [EmailAddress(ErrorMessage="Email is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a topic in the dropdown")]
        public string WhatSoftware { get; set; }

        [Required(ErrorMessage = "Please type the displayed number in the anti-spam field")]
        [MinLength(3, ErrorMessage = "Anti-spam check, please add the correct number into the box")]
        [MaxLength(3, ErrorMessage = "Please enter the correct number in the anti-spam field")]
        public string antispam { get; set; }

        [Required(ErrorMessage="Please add a subject...")]
        [MinLength(5, ErrorMessage= "Minimum 5 characters required for subject")]
        [MaxLength(300, ErrorMessage="Maximum 300 characters allowed for subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage="Please add a message...")]
        [MinLength(10, ErrorMessage= "Minimum 10 characters required for message")]
        [MaxLength(10001, ErrorMessage= "Oops - maximum 10000 characters allowed for message")]
        public string Message { get; set; }
    }
}