namespace Business.Requests.Customer;

public class GetCustomerListRequest
{
    public int? FilterIndividualId { get; set; }
    public int? FilterCorporateId { get; set; }
    
}