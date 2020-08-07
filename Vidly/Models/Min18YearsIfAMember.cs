using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate Is Required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)   //if block
                ? ValidationResult.Success  //retutn block
                : new ValidationResult("Customer Should be atleast 18 Years old to go on a membership."); //else block
        
        
        
        }
    }
}