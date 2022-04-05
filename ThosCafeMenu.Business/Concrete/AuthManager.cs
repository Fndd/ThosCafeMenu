using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Business.Abstract;
using ThosCafeMenu.Business.Constants;
using ThosCafeMenu.Core.Utilities.Results;
using ThosCafeMenu.Core.Utilities.Security.Hashing;
using ThosCafeMenu.Entity;
using ThosCafeMenu.Entity.DTOs;

namespace ThosCafeMenu.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService; 

        public AuthManager(IUserService userService)
        {
            _userService = userService; 
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                EMAIL = userForRegisterDto.Email,
                NAME = userForRegisterDto.Name,
                SURNAME = userForRegisterDto.Surname,
                HASHPASSWORD = passwordHash,
                SALTPASSWORD = passwordSalt,
                 
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(userToCheck, Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.HASHPASSWORD, userToCheck.SALTPASSWORD))
            {
                return new ErrorDataResult<User>(userToCheck, Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        } 
    }
}
