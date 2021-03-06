﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Week5CodeChallenge.Models
{
    [MetadataType(typeof(ContactInfoValidation))]
    public partial class ContactInfo
    {

    }

    public class ContactInfoValidation
    {
        [Required(ErrorMessage="Please enter your first name."), Display(Name="First Name"), MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name."), Display(Name = "Last Name"), MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter in your email."), EmailAddress(ErrorMessage = "Please enter in a valid email address"), MaxLength(50), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number."), Display(Name = "Phone Number"), MaxLength(50)]
        public string PhoneNum { get; set; }
        [Required(ErrorMessage = "Please enter your company name."), Display(Name = "Company Name"), MaxLength(50)]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Please tell us about your project."), Display(Name = "Project Description"), MaxLength(250)]
        public string ProjectDescription { get; set; }
        [Required(ErrorMessage = "Please tell us why you are contacting us."), DataType(DataType.MultilineText), MaxLength(1000)]
        public string Comment { get; set; }
       

    }
}
