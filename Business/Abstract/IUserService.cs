using Business.Requests.User;
using Business.Responses.Model;
using Business.Responses.User;
using Entities.Concrete;

namespace Business.Abstract;

public interface IUserService
{
    GetUserListResponse GetList(GetUserListRequest request);
    GetUserByIdResponse GetById(GetUserByIdRequest request);
    AddUserResponse Add(AddUserRequest request);
    UpdateUserResponse Update(UpdateUserRequest request);
    DeleteUserResponse Delete(DeleteUserRequest request);
}