namespace Business.Requests.CorporateCustomer;

public class UpdateCorporateCustomerRequest
{
    public UpdateCorporateCustomerRequest(string companyName, string taxNo, int userId)
    {
        CompanyName = companyName;
        TaxNo = taxNo;
        UserId = userId;
    }

    public string CompanyName { get; set; }
    public string TaxNo { get; set; }

    public int UserId { get; set; }
}