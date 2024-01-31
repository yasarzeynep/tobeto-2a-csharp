namespace Business;

public class AddCorporateCustomerResponse
{
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }

    public AddCorporateCustomerResponse(string companyName, string taxNo, int userId, DateTime createdAt)
    {
        CompanyName = companyName;
        TaxNo = taxNo;
        UserId = userId;
        CreatedAt = createdAt;
    }
}