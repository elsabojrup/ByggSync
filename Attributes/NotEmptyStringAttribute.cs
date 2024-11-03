using System;
using System.ComponentModel.DataAnnotations;

namespace QuestionManagementAPI.Attributes
{
    public class NotEmptyStringAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string strValue && string.IsNullOrWhiteSpace(strValue))
            {
                return new ValidationResult(ErrorMessage ?? $"{validationContext.DisplayName} får inte vara tom.");
            }
            return ValidationResult.Success;
        }
    }
}
