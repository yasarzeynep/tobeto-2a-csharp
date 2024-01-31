namespace Business
{
    public class UpdateIndividualCustomerResponse
    {   
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime UpdateAt { get; set; }

        public UpdateIndividualCustomerResponse(int userId, string firstName, string lastName, string nationalIdentity, DateTime updateAt)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            UpdateAt = updateAt;
        }
    }
}

