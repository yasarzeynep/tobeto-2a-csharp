using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class CustomerBusinessRules
{
    private readonly ICustomerDal _customerDal;

    public CustomerBusinessRules(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public void CheckIfCustomerExists(Customer? customer)
    {
        if (customer is null)
        {
            throw new NotFoundException("Customer not found.");
        }
    }

    //public void CheckIfCustomerNameExists(string name)
    //{
    //    bool isNameExists = _customerDal.Get(c => c.Name == name) != null;
    //    if (isNameExists)
    //    {
    //        throw new BusinessException("Customer name already exists.");
    //    }
    //}
}
