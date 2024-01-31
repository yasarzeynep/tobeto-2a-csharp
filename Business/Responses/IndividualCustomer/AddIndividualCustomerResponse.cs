namespace Business
{
    public class AddIndividualCustomerResponse
    {
        public AddIndividualCustomerResponse(string firstName, string lastName, string nationalIdentity, DateTime createdAt)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            CreatedAt = createdAt;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}