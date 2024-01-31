namespace Business.Responses.User;

    public class DeleteUserResponse
    {
    public DeleteUserResponse(int userId, string name, DateTime deletedAt)
    {
        UserId = userId;
        Name = name;
        DeletedAt = deletedAt;
    }

    public int UserId { get; set; }
    public string Name { get; set; }
    public DateTime DeletedAt { get; set; }
}
