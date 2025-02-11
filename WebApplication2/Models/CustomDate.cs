using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebApplication2.Models
{
    public class CustomDate : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            if (Convert.ToDateTime(context.Model) > DateTime.Now)
                return new List<ModelValidationResult> {
                    new ModelValidationResult("", "Date of Birth cannot be in the future")
                };
            else if (Convert.ToDateTime(context.Model) < new DateTime(1980, 1, 1))
                return new List<ModelValidationResult> {
                    new ModelValidationResult("", "Date of Birth should not be before 1980")
                };
            else
                return Enumerable.Empty<ModelValidationResult>();
        }
    }
}
