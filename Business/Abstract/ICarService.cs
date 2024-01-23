using Business.Requests.Brand;
using Business.Requests.Car;
using Business.Requests.Model;
using Business.Responses.Brand;
using Business.Responses.Car;
using Business.Responses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICarService
{
    public GetListCarResponse GetList(GetListCarRequest request);
    public GetCarByIdResponse GetById(GetCarByIdRequest request);
    public AddCarResponse Add(AddCarRequest request);
    public UpdateCarResponse Update(UpdateCarRequest request);
    public DeleteCarResponse Delete(DeleteCarRequest request);
}
