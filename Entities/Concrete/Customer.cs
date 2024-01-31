using Core.Entities;
namespace Entities.Concrete;

public class Customer: Entity<int>
{
    public int UserId { get; set; }

    public Customer(int userId)
    {
        UserId = userId;
    }
    public User? User { get; set; }= null;
    public  IndividualCustomer? IndividualCustomer { get; set; } = null;
    public CorporateCustomer? CorporateCustomer { get; set; }= null;
}
