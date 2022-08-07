using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Vidly.Models
{
    public class Min18YearsIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            var customer = (Customer)context.ObjectInstance;
            if (customer.MembershipTypeIds == 1)
            {
                return ValidationResult.Success;
            }

            var age = DateTime.Today.Year - customer.Birthdate.Year;
            if (customer.Birthdate == null || age<18)
            {
                return new ValidationResult("Birthdate is required.");
            }
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Must be at least 18 years old to apply for membership.");
        }
    }
    }
 