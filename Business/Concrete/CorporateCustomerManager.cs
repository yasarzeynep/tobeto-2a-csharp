﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.CorporateCustomer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CorporateCustomerManager : ICorporateCustomerService
{
    private readonly ICorporateCustomerDal _corporateCustomerDal;
    private readonly CorporateCustomerBusinessRules _corporateCustomerBusinessRules;
    private readonly IMapper _mapper;

    public CorporateCustomerManager(ICorporateCustomerDal corporateCustomerDal, CorporateCustomerBusinessRules corporateCustomerBusinessRules, IMapper mapper)
    {
        _corporateCustomerDal = corporateCustomerDal;
        _corporateCustomerBusinessRules = corporateCustomerBusinessRules;
        _mapper = mapper;
    }

    public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request)
    {
        throw new NotImplementedException();
    }

    public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request)
    {
        throw new NotImplementedException();
    }

    public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request)
    {
        throw new NotImplementedException();
    }

    public UpdateCorporateCustomerResponse Update(UpdateCorporateCustomerRequest request)
    {
        throw new NotImplementedException();
    }
}
