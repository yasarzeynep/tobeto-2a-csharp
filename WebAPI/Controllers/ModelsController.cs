using Business.Abstract;
using Business.Requests.Model;
using Business.Responses.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelsController : ControllerBase
{
    private readonly IModelService _modelService;

    public ModelsController(IModelService modelService)
    {
        _modelService = modelService;
    }
    [HttpGet] //Get
    public GetModelListResponse GetList([FromQuery] GetModelListRequest request)
    {
        GetModelListResponse response = _modelService.GetList(request);
        return response;
    }
    [HttpGet("{Id}")] //Get
    public GetModelByIdResponse GetById([FromRoute] GetModelByIdRequest request)
    {
        GetModelByIdResponse response = _modelService.GetById(request);
        return response;
    }

    [HttpPost] // Post
    public ActionResult<AddModelResponse> Add(AddModelRequest request)
    {
        AddModelResponse response = _modelService.Add(request);
        return CreatedAtAction( // 201 Created
            actionName: nameof(GetById),
            routeValues: new { Id = response.Id },

            value: response // Response Body: JSON
        );
    }
    [HttpPut("{Id}")] // Put 
    public ActionResult<UpdateModelResponse> Update(
        [FromRoute] int Id,
        [FromBody] UpdateModelRequest request
    )
    {
        if (Id != request.Id)
            return BadRequest();

        UpdateModelResponse response = _modelService.Update(request);
        return Ok(response);
    }

    [HttpDelete("{Id}")] // Delete
    public DeleteModelResponse Delete([FromRoute] DeleteModelRequest request)
    {
        DeleteModelResponse response = _modelService.Delete(request);
        return response;
    }

}
