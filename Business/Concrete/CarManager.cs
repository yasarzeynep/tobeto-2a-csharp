using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Dtos.Car;
using Business.Requests.Car;
using Business.Responses.Car;
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private readonly ICarDal _carDal;
    private readonly CarBusinessRules _carBusinessRules;
    private readonly IMapper _mapper;

    public CarManager(ICarDal carDal, CarBusinessRules carBusinessRules, IMapper mapper)
    {
        _carDal = carDal;
        _carBusinessRules = carBusinessRules;
        _mapper = mapper;
    }

    public AddCarResponse Add(AddCarRequest request)
    {
        _carBusinessRules.ModelValidateCar(request);

        // Mapping
        var carToAdd = _mapper.Map<Car>(request);

        // Data operations
        Car createdCar = _carDal.Add(carToAdd);

        // Response
        var response = _mapper.Map<AddCarResponse>(createdCar);
        return response;
    }

    public DeleteCarResponse Delete(DeleteCarRequest request)
    {
        // Data operations
        Car deletedCar = _carDal.Get(predicate: car => car.Id == request.Id);

        // Silme işlemini gerçekleştir
        _carDal.Delete(deletedCar);

        // Response
        var response = _mapper.Map<DeleteCarResponse>(deletedCar);
        response.Message = "Car deleted successfully.";
        return response;

    }
        public GetCarByIdResponse GetById(GetCarByIdRequest request)
        {
        var car = _carDal.Get(predicate: car => car.Id == request.Id);
        var response = _mapper.Map<GetCarByIdResponse>(car);
        return response;
    }


    public GetCarListResponse GetList(GetCarListRequest request)
    {
        var cars = _carDal.GetList();

        // Mapping
        var response = _mapper.Map<List<CarListItemDto>>(cars);
        return new GetCarListResponse { Items = response };
    }

    public UpdateCarResponse Update(UpdateCarRequest request)
    {
        // business rules
        _carBusinessRules.ModelValidateCar(request);

        // Mapping
        var carToUpdate = _mapper.Map<Car>(request);

        // Data operations
        _carDal.Update(carToUpdate);

        // Response
        return new UpdateCarResponse(
            carToUpdate.ColorId,
            carToUpdate.ModelId,
            carToUpdate.CarState,
            carToUpdate.Kilometer,
            carToUpdate.ModelYear,
            carToUpdate.Plate,
            "Car updated successfully.",
            DateTime.Now
        );
    }

}



