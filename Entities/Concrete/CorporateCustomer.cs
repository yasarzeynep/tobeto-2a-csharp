namespace Entities.Concrete;

public class CorporateCustomer
{
  
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }


    public int UserId { get; set; }
    public User? User { get; set; } = null;
    public Customer? Customer { get; set; } = null;

    public CorporateCustomer(string companyName, string taxNo)
    {
        CompanyName = companyName;
        TaxNo = taxNo;
    }
}
