using Business.Requests.Model;
using Business.Responses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelService
    {
        public GetModelListResponse GetList(GetModelListRequest request);
        public GetModelByIdResponse GetById(GetModelByIdRequest request);
        public AddModelResponse Add(AddModelRequest request);
        public UpdateModelResponse Update(UpdateModelRequest request);
        public DeleteModelResponse Delete(DeleteModelRequest request);
  
    }
}
