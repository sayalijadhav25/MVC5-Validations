using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationsInMVC.CustomValidations;


namespace ValidationsInMVC.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "First name should have characters between 2 and 20")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        // [StringLength(10, MinimumLength = 5)]
        [MaxLength(10, ErrorMessage = "last name cannot be more than 10 characters")]
        [MinLength(5, ErrorMessage = "last name should have more than 5 characters")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        // [Range(1, 100, ErrorMessage = "age should be between 1 and 100")]
        [Range(1, 100, ErrorMessage = "age should be between 1 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter your date of birth")]
        [DisplayName("Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[AgeLimitValidation(18)]
        [AgeLimitValidation(25)]
        // [CustomDateValidation]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email")]
        // [EmailAddress(ErrorMessage = "Invalid email")]
        // [DataType(DataType.EmailAddress)]
      //  [Remote("IsEmailExists", "Users", ErrorMessage = "Email already registered. Please register using another email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Weak password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your facebook profile page")]
        // [Url(ErrorMessage = "Invalid url")]
        [DataType(DataType.Url, ErrorMessage = "Invalid url")]
        public string FacebookProfileURL { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "email and confirm email should be same")]
        [DisplayName("Confirm Email")]
        public string ConfirmEmail { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "password and confirm password should be same")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}