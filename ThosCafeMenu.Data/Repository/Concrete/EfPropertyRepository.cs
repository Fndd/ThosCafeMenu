using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Entity;
using ThosCafeMenu.Data.Repository.Abstract;

namespace ThosCafeMenu.Data.Repository.Concrete
{
    public class EfPropertyRepository : EfEntityRepositoryBase<Property, dbContext>, IPropertyRepository
    {
    }
}
