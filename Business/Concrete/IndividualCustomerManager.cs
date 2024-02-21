using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.IndividualCustomer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class IndividualCustomerManager : IIndividualCustomerService
{
    private readonly IIndividualCustomerDal _individualCustomerDal;
    private readonly IndividualCustomerBusinessRules _individualCustomerBusinessRules;
    private readonly IMapper _mapper;

    public IndividualCustomerManager(IIndividualCustomerDal individualCustomerDal, IndividualCustomerBusinessRules individualCustomerBusinessRules, IMapper mapper)
    {
        _individualCustomerDal = individualCustomerDal;
        _individualCustomerBusinessRules = individualCustomerBusinessRules;
        _mapper = mapper;
    }

    public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request)
    {
        throw new NotImplementedException();
    }

    public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request)
    {
        throw new NotImplementedException();
    }

    public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request)
    {
        throw new NotImplementedException();
    }

    public UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request)
    {
        throw new NotImplementedException();
    }
}
