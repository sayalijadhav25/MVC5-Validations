using System;
using System.ComponentModel.DataAnnotations;

namespace ValidationsInMVC.CustomValidations
{
    public class AgeLimitValidationAttribute : ValidationAttribute
    {
        private readonly int _ageLimit;

        public AgeLimitValidationAttribute(int ageLimit)
        {
            _ageLimit = ageLimit;
        }

        protected override ValidationResult IsValid(object value,
                                                        ValidationContext validationContext)
        {
            if (value is DateTime inputDate)
            {
                var today = DateTime.Today;
                var ageDifference = today.Year - inputDate.Year;

                // Adjust for birthdays that haven't occurred yet this year
                if (inputDate > today.AddYears(-ageDifference))
                    ageDifference--;

                if (ageDifference >= _ageLimit)
                    return ValidationResult.Success;

                return new ValidationResult($"Date must correspond to an age of at least {_ageLimit} years.");
            }

            return new ValidationResult("Invalid date format.");
        }
    }
}