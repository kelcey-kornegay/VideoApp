﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VideoApp.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer =(Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown
                || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.BirthDay == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.BirthDay.Value.Year;

            return (age >= 18) ? ValidationResult.Success
                     : new ValidationResult("Customer should be over 18 years old");

                    
        }
    }
}