using Business.Dtos.Model;

namespace Business;


public class GetCustomerListResponse
{
    public ICollection<CustomerListItemDto> Items { get; set; }
}