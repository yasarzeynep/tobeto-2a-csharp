namespace Business;

public class UpdateIndividualCustomerRequest
{
    public UpdateIndividualCustomerRequest(string firstName, string lastName, string nationalIdentity, int userId)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
        UserId = userId;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }

    public int UserId { get; set; }
}