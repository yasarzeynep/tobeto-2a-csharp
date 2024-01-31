namespace Business.Requests.CorporateCustomer;
public class GetCorporateCustomerListRequest
{
    public int? FilterIndividualId { get; set; }
    public int? FilterCorporateId { get; set; }
}