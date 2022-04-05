using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Core.Utilities.Results;
using ThosCafeMenu.Entity;

namespace ThosCafeMenu.Business.Abstract
{
    public interface IProductPropertyService
    {
        IDataResult<List<ProductProperty>> GetAll();
        IDataResult<ProductProperty> GetById(int productPropertyId);
        IResult Add(ProductProperty productProperty);
        IResult Update(ProductProperty productProperty);
        IResult Delete(ProductProperty productProperty);
    }
}
