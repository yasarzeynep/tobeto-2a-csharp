 namespace Business.Responses.Customer;

public class AddCustomerResponse
{
    public AddCustomerResponse(int userId, string firstName, string lastName, string email, string password, string nationalIdentity, string companyName, string taxNo)
    {
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        NationalIdentity = nationalIdentity;
        CompanyName = companyName;
        TaxNo = taxNo;
    }

    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string NationalIdentity { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }

}