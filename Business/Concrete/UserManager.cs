using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.User;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class UserManager : IUserService
{
    private readonly IUserDal _userDal;
    private readonly UserBusinessRules _userBusinessRules;
    private readonly IMapper _mapper;

    public UserManager(IUserDal userDal, UserBusinessRules userBusinessRules, IMapper mapper)
    {
        _userDal = userDal;
        _userBusinessRules = userBusinessRules;
        _mapper = mapper;
    }

}
 
