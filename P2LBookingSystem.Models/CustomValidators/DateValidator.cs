using System.ComponentModel.DataAnnotations;

namespace P2LBookingSystem.Models.CustomValidators
{
    public class DateValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            return base.IsValid(value, validationContext);
        }
    }
}