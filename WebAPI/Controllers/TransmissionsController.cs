using Business.Abstract;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        private readonly ITransmissionService _transmissionService;

        public TransmissionsController(ITransmissionService transmissionService)
        {
            _transmissionService = transmissionService;
        }

        [HttpPost("Add")]
        public ActionResult<AddTransmissionResponse> AddTransmission(AddTransmissionRequest request)
        {
            var response = _transmissionService.Add(request);
            return Ok(response);
        }

        [HttpGet("GetList")]
        public ActionResult<GetListTransmissionResponse> GetTransmissions([FromQuery] GetListTransmissionRequest request)
        {
            var response = _transmissionService.GetList(request);
            return Ok(response);
        }

        [HttpGet("GetById")]
        public ActionResult<GetTransmissionByIdResponse> GetTransmissionById([FromQuery] GetTransmissionByIdRequest request)
        {
            var response = _transmissionService.GetById(request);
            if (response == null)
            {
                return NotFound("Transmission not found.");
            }
            return Ok(response);
        }

        [HttpPut("Update")]
        public ActionResult<UpdateTransmissionResponse> UpdateTransmission(UpdateTransmissionRequest request)
        {
            var response = _transmissionService.Update(request);
            if (response == null)
            {
                return NotFound("Transmission not found.");
            }
            return Ok(response);
        }

        [HttpDelete("Delete")]
        public ActionResult<DeleteTransmissionResponse> DeleteTransmission(DeleteTransmissionRequest request)
        {
            var response = _transmissionService.Delete(request);
            if (response == null)
            {
                return NotFound("Transmission not found.");
            }
            return Ok(response);
        }
    }
}
