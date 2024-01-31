using Core.Entities;

namespace Entities.Concrete;

public class IndividualCustomer : Entity<int>
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }

    public int UserId { get; set; }

    public User ? User { get; set; }  = null;
    public Customer? Customer { get; set; }=null;

    public IndividualCustomer(string firstName, string lastName, string nationalIdentity)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
    }
}
