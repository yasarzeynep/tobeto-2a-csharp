using Business.Requests.Transmission;
using Business.Responses.Transmission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;
public interface ITransmissionService

{
    /* CRUD:Create-->Add; Read-->GetList, GetById, GetAll; Update-->Update; Delete-->Delete
     Transmission Add(Transmission transmission);
     IList<Transmission> GetList();
     Transmission GetById(int id);
     IList<Transmission> GetAll();
     Transmission Update(Transmission transmission);
     void Delete(int id);
    */
    AddTransmissionResponse Add(AddTransmissionRequest request);
    GetListTransmissionResponse GetList(GetListTransmissionRequest request);
    GetTransmissionResponse Get(GetByIdTransmissionRequest request);
    UpdateTransmissionResponse Update(UpdateTransmissionRequest request);
    DeleteTransmissionResponse Delete(DeleteTransmissionRequest request);
}
