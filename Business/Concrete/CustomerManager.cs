using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.Customer;
using Business.Requests.Customer;
using Business.Responses.Customer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerManager : ICustomerService
{
    private readonly ICustomerDal _customerDal;
    private readonly CustomerBusinessRules _customerBusinessRules;
    private readonly IMapper _mapper;

    public CustomerManager(ICustomerDal customerDal, CustomerBusinessRules customerBusinessRules, IMapper mapper)
    {
        _customerDal = customerDal;
        _customerBusinessRules = customerBusinessRules;
        _mapper = mapper;
    }

    public AddCustomerResponse Add(AddCustomerRequest request)
    {
        throw new NotImplementedException();
    }

    public DeleteCustomerResponse Delete(DeleteCustomerRequest request)
    {
        throw new NotImplementedException();
    }

    public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public GetCustomerListResponse GetList(GetCustomerListRequest request)
    {
        throw new NotImplementedException();
    }

    public UpdateCustomerResponse Update(UpdateCustomerRequest request)
    {
        throw new NotImplementedException();
    }
}
