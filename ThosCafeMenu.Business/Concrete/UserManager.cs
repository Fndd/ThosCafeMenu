using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Business.Abstract;
using ThosCafeMenu.Data.Repository.Abstract;
using ThosCafeMenu.Entity;

namespace ThosCafeMenu.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        } 
        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userRepository.Get(u => u.EMAIL == email);
        }
    }
}
