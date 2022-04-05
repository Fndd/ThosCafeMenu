using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Core.Utilities.Results;
using ThosCafeMenu.Entity;
using ThosCafeMenu.Entity.DTOs;

namespace ThosCafeMenu.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email); 

    }
}
