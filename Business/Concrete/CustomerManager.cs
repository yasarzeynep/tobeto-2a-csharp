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
        ValidationTool.Validate(new AddCustomerRequestValidator(), request);

        _customerBusinessRules.CheckIfCustomerNameExists(request.Name);

        var customerToAdd = _mapper.Map<Customer>(request);

        Customer addedCustomer = _customerDal.Add(customerToAdd);

        var response = _mapper.Map<AddCustomerResponse>(addedCustomer);
        return response;
    }

    public DeleteCustomerResponse Delete(DeleteCustomerRequest request)
    {
        Customer? customerToDelete = _customerDal.Get(predicate: customer => customer.Id == request.Id);
        _customerBusinessRules.CheckIfCustomerExists(customerToDelete);

        Customer deletedCustomer = _customerDal.Delete(customerToDelete!);

        var response = _mapper.Map<DeleteCustomerResponse>(deletedCustomer);
        return response;
    }

    public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request)
    {
        Customer? customer = _customerDal.Get(predicate: customer => customer.Id == request.Id);
        _customerBusinessRules.CheckIfCustomerExists(customer);

        var response = _mapper.Map<GetCustomerByIdResponse>(customer);
        return response;

    }
    public GetCustomerListResponse GetList(GetCustomerListRequest request)
    {
        throw new NotImplementedException();
    }

    public UpdateCustomerResponse Update(UpdateCustomerRequest request)
    {
        Customer? customerToUpdate = _customerDal.Get(predicate: customer => customer.Id == request.Id);
        _customerBusinessRules.CheckIfCustomerExists(customerToUpdate);

        customerToUpdate = _mapper.Map(request, customerToUpdate);
        Customer updatedCustomer = _customerDal.Update(customerToUpdate!);

        var response = _mapper.Map<UpdateCustomerResponse>(updatedCustomer);
        return response;
    }
}
