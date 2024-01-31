using Business.Dtos.Model;
using Business.Dtos.User;

namespace Business.Responses.User;
public class GetUserListResponse
    {
    public ICollection<UserListItemDto> Items { get; set; }

}
