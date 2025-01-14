﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class FuelManager : IFuelService
{
    private readonly IFuelDal _fuelDal;
    private readonly FuelBusinessRules _fuelBusinessRules;
    private readonly IMapper _mapper;

    public FuelManager(IFuelDal fuelDal, FuelBusinessRules fuelBusinessRules, IMapper mapper)
    {
        _fuelDal = fuelDal;
        _fuelBusinessRules = fuelBusinessRules;
        _mapper = mapper;
    }
    public AddFuelResponse Add(AddFuelRequest request)
    {
        _fuelBusinessRules.CheckIfFuelExistsForAdd(request.Name);

        Fuel fuelToAdd = _mapper.Map<Fuel>(request);
        _fuelDal.Add(fuelToAdd);

        AddFuelResponse response = _mapper.Map<AddFuelResponse>(fuelToAdd);
        return response;
    }

    public DeleteFuelResponse Delete(DeleteFuelRequest request)
    {
        throw new NotImplementedException();
    }

    public GetFuelByIdResponse Get(GetFuelByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public GetListFuelResponse GetList(GetListFuelRequest request)
    {
        throw new NotImplementedException();
    }

    public UpdateFuelResponse Update(UpdateFuelRequest request)
    {
        throw new NotImplementedException();
    }
}

    


