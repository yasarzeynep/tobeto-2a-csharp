using Business.Requests.Fuel;
using Business.Responses.Brand;
using Business.Responses.Fuel;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFuelService
    {
        /*
        CRUD:Create-->Add; Read-->GetList, GetById, GetAll; Update-->Update; Delete-->Delete
        public Fuel Add(Fuel fuel);
        public IList<Fuel> GetList();
        public Fuel GetById(int id);
        public Fuel Update(Fuel fuel);
        public void Delete(int id); // void:Döndürülecek bir sonuc yok
        */
        public AddFuelResponse Add(AddFuelRequest request);
        public GetListFuelResponse GetList(GetListFuelRequest request);
        public GetFuelByIdResponse Get(GetFuelByIdRequest request);
        public UpdateFuelResponse Update(UpdateFuelRequest request);
        public DeleteFuelResponse Delete(DeleteFuelRequest request);

    }
}
