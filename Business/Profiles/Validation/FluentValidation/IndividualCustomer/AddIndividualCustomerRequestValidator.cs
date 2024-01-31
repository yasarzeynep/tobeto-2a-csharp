using Business.Requests.Model;
using FluentValidation;

namespace Business
{
    public class AddIndividualCustomerRequestValidator : AbstractValidator<AddIndividualCustomerRequest>
    {
        public AddIndividualCustomerRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(100);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(100);
            RuleFor(x => x.NationalIdentity).NotEmpty().Length(50); 
            RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);
          
        }
    }
}