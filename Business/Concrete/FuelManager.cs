using AutoMapper;
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
    public AddFuelResponse Add(AddFuelRequest request)
    {
        // Ekleme işlemi için iş kurallarını kontrol et
        _fuelBusinessRules.CheckIfFuelExistsForAdd(request.Name);

        var fuelToAdd = _mapper.Map<Fuel>(request);
        _fuelDal.Add(fuelToAdd);

        return _mapper.Map<AddFuelResponse>(fuelToAdd);
    }
    public GetFuelByIdResponse GetById(GetFuelByIdRequest request)
    {
        // GetById işlemi için iş kurallarını kontrol et
        _fuelBusinessRules.CheckIfIdIsValidForGetById(request.Id);
        _fuelBusinessRules.CheckIfFuelExistsForGetById(request.Id);

        var fuel = _fuelDal.GetById(request.Id);

        return _mapper.Map<GetFuelByIdResponse>(fuel);
    }
    public UpdateFuelResponse Update(UpdateFuelRequest request)
    {
        // Güncelleme işlemi için iş kurallarını kontrol et
        _fuelBusinessRules.CheckIfIdIsValidForGetById(request.Id);
        _fuelBusinessRules.CheckIfFuelExistsForUpdate(request.Id, request.Name);

        var existingFuel = _fuelDal.GetById(request.Id);
        if (existingFuel == null)
        {
            throw new Exception("Fuel not found for Update.");
        }

        existingFuel.Name = request.Name;
        _fuelDal.Update(existingFuel);

        return _mapper.Map<UpdateFuelResponse>(existingFuel);
    }

    public DeleteFuelResponse Delete(DeleteFuelRequest request)
    {
        // Silme işlemi için iş kurallarını kontrol et
        _fuelBusinessRules.CheckIfIdIsValidForGetById(request.Id);
        _fuelBusinessRules.CheckIfFuelExistsForDelete(request.Id);

        var fuelToDelete = _fuelDal.GetById(request.Id);
        if (fuelToDelete == null)
        {
            throw new Exception("Fuel not found for Delete.");
        }

        _fuelDal.Delete(fuelToDelete);

        return _mapper.Map<DeleteFuelResponse>(fuelToDelete);
    }

    public GetListFuelResponse GetList(GetListFuelRequest request)
    {
        throw new NotImplementedException();
    }
}
}
    


