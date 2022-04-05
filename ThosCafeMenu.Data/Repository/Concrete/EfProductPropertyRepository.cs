using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Data.Repository.Abstract;
using ThosCafeMenu.Entity;

namespace ThosCafeMenu.Data.Repository.Concrete
{
    public class EfProductPropertyRepository : EfEntityRepositoryBase<ProductProperty, dbContext>, IProductPropertyRepository
    {
    }
}
