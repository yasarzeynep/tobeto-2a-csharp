using Business.Requests.Car;
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules;

public class CarBusinessRules
{
    private readonly ICarDal _carDal;

    public CarBusinessRules(ICarDal carDal)
    {
        _carDal = carDal;
    }

public void CheckIfCarPlateExists (string plate)
    {
        bool isPlateExists = _carDal.Get(c => c.Plate == plate) != null;
        if (isPlateExists)
        {
            throw new BusinessException("Car with the same plate already exists.");
        }

    }

    public void ModelValidateCar(AddCarRequest request)
    {
        if (request.ModelYear < DateTime.Now.Year - 20)
            throw new BusinessException("Model year cannot be more than 20 years ago.");
        if (request.ModelYear > DateTime.Now.Year)
            throw new BusinessException("Model year cannot be in the future.");
        if (string.IsNullOrWhiteSpace(request.Plate))
            throw new BusinessException("Plate cannot be empty.");

        CheckIfCarPlateExists(request.Plate);
    }
}
