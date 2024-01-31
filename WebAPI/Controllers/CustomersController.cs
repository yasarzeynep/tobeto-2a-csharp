using Business;
using Business.Abstract;
using Business.Requests.Customer;
using Business.Responses.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public GetCustomerListResponse GetList([FromQuery] GetCustomerListRequest request)
        {
            GetCustomerListResponse response = _customerService.GetList(request);
            return response;
        }

        [HttpGet("{userId}")]
        public GetCustomerByIdResponse GetById(int userId)
        {
            GetCustomerByIdRequest request = new GetCustomerByIdRequest { UserId = userId };
            GetCustomerByIdResponse response = _customerService.GetById(request);
            return response;
        }

        [HttpPost]
        public ActionResult<AddCustomerResponse> Add(AddCustomerRequest request)
        {
            AddCustomerResponse response = _customerService.Add(request);
            return CreatedAtAction(
                actionName: nameof(GetById),
                routeValues: new { userId = response.UserId },
                value: response
            );
        }

        [HttpPut("{userId}")]
        public ActionResult<UpdateCustomerResponse> Update(int userId, [FromBody] UpdateCustomerRequest request)
        {
            if (userId != request.UserId)
                return BadRequest();

            UpdateCustomerResponse response = _customerService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{userId}")]
        public DeleteCustomerResponse Delete(int userId)
        {
            DeleteCustomerRequest request = new DeleteCustomerRequest { UserId = userId };
            DeleteCustomerResponse response = _customerService.Delete(request);
            return response;
        }
    }
}
