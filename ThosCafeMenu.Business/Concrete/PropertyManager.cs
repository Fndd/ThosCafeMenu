using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Business.Abstract;
using ThosCafeMenu.Business.Constants;
using ThosCafeMenu.Core.Utilities.Results;
using ThosCafeMenu.Data.Repository.Abstract;
using ThosCafeMenu.Entity;

namespace ThosCafeMenu.Business.Concrete
{
    public class PropertyManager : IPropertyService
    {
        IPropertyRepository _propertyRepository;
        public PropertyManager(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public IResult Add(Property property)
        {
            _propertyRepository.Add(property);
            return new SuccessResult(Messages.PropertyAdded);
        }
        public IResult Update(Property property)
        {
            _propertyRepository.Update(property);
            return new SuccessResult(Messages.PropertyUpdated);
        }

        public IResult Delete(Property property)
        {
            _propertyRepository.Delete(property);
            return new SuccessResult(Messages.PropertyDeleted);
        }

        public IDataResult<List<Property>> GetAll()
        {
            return new SuccessDataResult<List<Property>>(_propertyRepository.GetAll());
        }

        public IDataResult<Property> GetById(int propertyId)
        {
            return new SuccessDataResult<Property>(_propertyRepository.Get(p => p.ID == propertyId));

        }

    }
}
