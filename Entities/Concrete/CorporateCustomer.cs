using Core.Entities;

namespace Entities.Concrete;

public class CorporateCustomer : Entity<int>
{
    public CorporateCustomer(string companyName, string taxNo)
    {
        CompanyName = companyName;
        TaxNo = taxNo;
        
    }

    public CorporateCustomer()
    {
    }

    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public User? User { get; set; } = null;
    public Customer? Customer { get; set; } = null;

   
}
