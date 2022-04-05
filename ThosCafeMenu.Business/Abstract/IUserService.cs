using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Entity;

namespace ThosCafeMenu.Business.Abstract
{
    public interface IUserService
    { 
        void Add(User user);
        User GetByMail(string email);
    }
}
