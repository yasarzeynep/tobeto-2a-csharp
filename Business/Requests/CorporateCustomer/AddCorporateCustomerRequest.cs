namespace Business.Requests.CorporateCustomer;

public class AddCorporateCustomerRequest
{
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }

    public int UserId { get; set; }

    public AddCorporateCustomerRequest(string companyName, string taxNo, int userId)
    {
        CompanyName = companyName;
        TaxNo = taxNo;
        UserId = userId;
    }

}