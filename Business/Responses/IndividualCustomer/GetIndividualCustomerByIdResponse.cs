namespace Business;

public class GetIndividualCustomerByIdResponse
{
    public GetIndividualCustomerByIdResponse(string firstName, string lastName, string nationalIdentity)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }

   
}