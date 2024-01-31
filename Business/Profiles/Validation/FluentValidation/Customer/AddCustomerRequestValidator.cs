using Business.Requests.Customer;
using Business.Requests.Model;
using FluentValidation;

namespace Business.Profiles.Validation.FluentValidation.Customer
{
    public class AddCustomerRequestValidator : AbstractValidator<AddCustomerRequest>
    {
        public AddCustomerRequestValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Id).NotEmpty().GreaterThan(0);
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(100);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(100);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
        }
    }
}