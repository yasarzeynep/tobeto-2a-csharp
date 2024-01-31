

using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class IndividualCustomerBusinessRules
{
    private readonly IIndividualCustomerDal _individualCustomerDal;

    public IndividualCustomerBusinessRules(IIndividualCustomerDal individualCustomerDal)
    {
        _individualCustomerDal = individualCustomerDal;
    }

    public void CheckIfFirstNameExists(string firstName)
    {
        bool isFirstNameExists = _individualCustomerDal.Get(ic => ic.FirstName == firstName) != null;
        if (isFirstNameExists)
        {
            throw new BusinessException("First name already exists.");
        }
    }

    public void CheckIfIndividualCustomerExists(IndividualCustomer? individualCustomer)
    {
        if (individualCustomer is null)
        {
            throw new NotFoundException("Individual customer not found.");
        }
    }

}
