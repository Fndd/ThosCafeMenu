using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Data;
using ThosCafeMenu.Data.Repository.Abstract;
using ThosCafeMenu.Data.Repository.Concrete;
using ThosCafeMenu.Entity;

namespace emarDepo.Data.Repository.Concrete
{
    public class EfUserRepository : EfEntityRepositoryBase<User, dbContext>, IUserRepository
    {
     
    }
}
