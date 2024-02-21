
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class UserBusinessRules
{
    private readonly IUserDal _userDal;

    public UserBusinessRules(IUserDal userDal)
    {
        _userDal = userDal;
    }

    //public void CheckIfUserEmailExists(string email)
    //{
    //    bool isEmailExists = _userDal.Get(u => u.Email == email) != null;
    //    if (isEmailExists)
    //    {
    //        throw new BusinessException("User email already exists.");
    //    }
    //}

    //public void CheckIfUserExists(User? user)
    //{
    //    if (user is null)
    //    {
    //        throw new NotFoundException("User not found.");
    //    }
    //}

}
