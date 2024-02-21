

using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class CorporateCustomerBusinessRules
{
    private readonly ICorporateCustomerDal _corporateCustomerDal;

    public CorporateCustomerBusinessRules(ICorporateCustomerDal corporateCustomerDal)
    {
        _corporateCustomerDal = corporateCustomerDal;
    }
    public void CheckIfCompanyNameExists(string companyName)
    {
        bool isCompanyNameExists = _corporateCustomerDal.Get(cc => cc.CompanyName == companyName) != null;
        if (isCompanyNameExists)
        {
            throw new BusinessException("Company name already exists.");
        }
    }

    public void CheckIfCorporateCustomerExists(CorporateCustomer? corporateCustomer)
    {
        if (corporateCustomer is null)
        {
            throw new NotFoundException("Corporate customer not found.");
        }

    }
}