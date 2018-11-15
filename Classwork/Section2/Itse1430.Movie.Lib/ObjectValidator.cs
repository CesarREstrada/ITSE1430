using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Itse1430.Movie.Lib
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> TryValidate( IValidatableObject value )
        {
            var results = new List<ValidationResult>();

            var context = new ValidationContext(value);

            Validator.TryValidateObject(value, context, results, true);

            return results;
        }

        public static void Validate( IValidatableObject value )
        {
            var context = new ValidationContext(value);

            Validator.ValidateObject(value, context, true);         // used for validation(validator)
        }
    }
}
