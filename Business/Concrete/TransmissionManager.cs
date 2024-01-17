﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete;

public class TransmissionManager : ITransmissionService
{
    private readonly ITransmissionDal _transmissionDal;
    private readonly TransmissionBusinessRules _transmissionBusinessRules;
    private readonly IMapper _mapper;

    public TransmissionManager(ITransmissionDal transmissionDal, TransmissionBusinessRules transmissionBusinessRules, IMapper mapper)
    {
        _transmissionDal = transmissionDal;
        _transmissionBusinessRules = transmissionBusinessRules;
        _mapper = mapper;
    }

    public AddTransmissionResponse Add(AddTransmissionRequest request)
    {
        _transmissionBusinessRules.CheckIfTransmissionNameExistsForAdd(request.Name);

        Transmission transmissionToAdd = _mapper.Map<Transmission>(request);
        _transmissionDal.Add(transmissionToAdd);

        AddTransmissionResponse response = _mapper.Map<AddTransmissionResponse>(transmissionToAdd);
        return response;
    }

    public GetListTransmissionResponse GetList(GetListTransmissionRequest request)
    {
        IList<Transmission> transmissionList = _transmissionDal.GetList();
        IList<GetByIdTransmissionResponse> responseList = _mapper.Map<IList<GetByIdTransmissionResponse>>(transmissionList);

        return new GetListTransmissionResponse { Transmissions = responseList };
    }

    public GetByIdTransmissionResponse GetById(GetByIdTransmissionRequest request)
    {
        Transmission transmission = _transmissionDal.GetById(request.Id);
        return _mapper.Map<GetByIdTransmissionResponse>(transmission);
    }

    public UpdateTransmissionResponse Update(UpdateTransmissionRequest request)
    {
        var existingTransmission = _transmissionDal.GetById(request.Id);
        if (existingTransmission == null)
        {
            return null; 
        }

        _transmissionBusinessRules.CheckIfTransmissionNameExistsForUpdate(request.Id, request.Name);

        existingTransmission.Name = request.Name;
        _transmissionDal.Update(existingTransmission);

        return _mapper.Map<UpdateTransmissionResponse>(existingTransmission);
    }

    public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request)
    {
        var transmissionToDelete = _transmissionDal.GetById(request.Id);
        if (transmissionToDelete == null)
        {
            return null; 
        }

        _transmissionDal.Delete(transmissionToDelete);

        return _mapper.Map<DeleteTransmissionResponse>(transmissionToDelete);
    }
}

