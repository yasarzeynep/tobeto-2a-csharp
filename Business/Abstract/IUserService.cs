using Business.Requests.User;
using Business.Responses.Model;
using Entities.Concrete;

namespace Business.Abstract;

public interface IUserService
{

    void Register(RegisterRequest request); 
    void Login(LoginRequest request); //TODO: return type: JWT
        
        
 }