using FluentValidation;

namespace VerticalSliceArchitecture.Common
{
    public class Validation
    {
        public static bool Validate<TValidator, TRequest>(TValidator validator, TRequest request)
            where TValidator : AbstractValidator<TRequest>
        {
            var result = validator.Validate(request);

            return result.Errors.Count != 0;
        }
    }
}
