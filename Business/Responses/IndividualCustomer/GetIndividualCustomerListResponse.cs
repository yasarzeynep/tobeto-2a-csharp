using Business.Dtos.Model;

namespace Business
{
    public class GetIndividualCustomerListResponse
    {
        public ICollection<IndividualCustomerListItemDto> Items { get; set; }
    }
}

