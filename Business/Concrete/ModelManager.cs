using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.Concrete;

public class ModelManager : IModelService
{
    private readonly IModelDal _modelDal;
    private readonly ModelBusinessRules _modelBusinessRules;
    private readonly IMapper _mapper;

    public ModelManager(IModelDal modelDal, ModelBusinessRules modelBusinessRules, IMapper mapper)
    {
        _modelDal = modelDal;
        _modelBusinessRules = modelBusinessRules;
        _mapper = mapper;
    }

    public AddModelResponse Add(AddModelRequest request)
    {
        if (request.Name.Length<2)
            throw new Exception("Name must be at  least  2 characters long"); 
        if (request.Name.Length>50)
            throw new Exception("Name cannot be longer 50 characters");  
        if (request.DailyPrice>0)
            throw new Exception("Daily price must be greater than 0");
        //TODO: Fluent Validation yap

        //business rules
        _modelBusinessRules.CheckIfModelNameExists(request.Name);

        //mapping 
        var modelToAdd = _mapper.Map<Model>(request);

        //data operations 
        Model updatedModel=_modelDal.Add(modelToAdd);

        //reponse
        var response = _mapper.Map<AddModelResponse>(updatedModel);
        return response;

    }
    public DeleteModelResponse Delete(DeleteModelRequest request)
    {
        var deletedModel = _modelDal.Delete(request.Id);

        return new DeleteModelResponse
        {
            Id = deletedModel.Id,
            Name = deletedModel.Name,
            DeletedAt = deletedModel.DeletedAt
        };
    }
        public GetModelByIdResponse GetById(GetModelByIdRequests request)
        {
            // Id'ye göre model getirme işlemini gerçekleştir
            var model = _modelDal.Get(request.Id);
            var response = _mapper.Map<GetModelByIdResponse>(model);
            return response;
        }

        public GetListModelResponse GetList(GetListModelRequest request)
    {
       
       bool predicate(Model model)
        {
            return (request.FilterByBrandId == null || model.BrandId == request.FilterByBrandId)
                  && (request.FilterByFuelId == null || model.FuelId == request.FilterByFuelId)
                  && (request.FilterByTransmissionId == null || model.TransmissionId == request.FilterByTransmissionId);
        }
       IList<Model> modelList = _modelDal.GetList(predicate);

        //mapping response
        var response = _mapper.Map<GetListModelResponse>(modelList);
        return response;
    }

    public UpdateModelResponse Update(UpdateModelRequest request)
    {
        _modelBusinessRules.CheckIfModelNameExists(request.Name);

        // Mapping
        var modelToUpdate = _mapper.Map<Model>(request);

        // Data operations
        _modelDal.Update(modelToUpdate);

        // Response
        return new UpdateModelResponse
        {
            Id = modelToUpdate.Id,
            BrandId = modelToUpdate.BrandId,
            FuelId = modelToUpdate.FuelId,
            TransmissionId = modelToUpdate.TransmissionId,
            Name = modelToUpdate.Name,
            DailyPrice = modelToUpdate.DailyPrice,
            Year = modelToUpdate.Year,
            UpdateAt = DateTime.Now,
        };
    }
}
