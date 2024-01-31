namespace Business;

public class DeleteIndividualCustomerResponse
{
    public DeleteIndividualCustomerResponse(int ıd, int usertId, string name, DateTime deletedAt)
    {
        Id = ıd;
        UsertId = usertId;
        Name = name;
        DeletedAt = deletedAt;
    }

    public int Id { get; set; }
    public int UsertId { get; set; }
    public string Name { get; set; }
    public DateTime DeletedAt { get; set; }
}