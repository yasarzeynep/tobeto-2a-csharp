using Business.Abstract;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuelsController : ControllerBase
{ 
private readonly IFuelService _fuelService;

public FuelsController(IFuelService fuelService)
{
    _fuelService = fuelService;
}

[HttpPost("Add")]
public ActionResult<AddFuelResponse> AddFuel(AddFuelRequest request)
{
    var response = _fuelService.Add(request);
    return Ok(response);
}

[HttpGet("GetList")]
public ActionResult<GetListFuelResponse> GetFuels([FromQuery] GetListFuelRequest request)
{
    var response = _fuelService.GetList(request);
    return Ok(response);
}

[HttpGet("GetById")]
public ActionResult<GetByIdFuelResponse> GetFuelById([FromQuery] GetByIdFuelRequest request)
{
    var response = _fuelService.GetById(request);
    if (response == null)
    {
        return NotFound();
    }
    return Ok(response);
}

[HttpPut("Update")]
public ActionResult<UpdateFuelResponse> UpdateFuel(UpdateFuelRequest request)
{
    var response = _fuelService.Update(request);
    if (response == null)
    {
        return NotFound();
    }
    return Ok(response);
}

[HttpDelete("Delete")]
public ActionResult<DeleteFuelResponse> DeleteFuel(DeleteFuelRequest request)
{
    var response = _fuelService.Delete(request);
    if (response == null)
    {
        return NotFound();
    }
    return Ok(response);
}

}
