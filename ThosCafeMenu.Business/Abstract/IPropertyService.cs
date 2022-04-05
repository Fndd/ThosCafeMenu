using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Core.Utilities.Results;
using ThosCafeMenu.Entity;

namespace ThosCafeMenu.Business.Abstract
{
    public interface IPropertyService
    {
        IDataResult<List<Property>> GetAll();
        IDataResult<Property> GetById(int propertyId);
        IResult Add(Property property);
        IResult Update(Property property);
        IResult Delete(Property property);
    }
}
