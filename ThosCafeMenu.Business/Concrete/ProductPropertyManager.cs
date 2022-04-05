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
    public class ProductPropertyManager : IProductPropertyService
    {
        IProductPropertyRepository _ProductPropertyRepository;
        public ProductPropertyManager(IProductPropertyRepository productPropertyRepository)
        {
            _ProductPropertyRepository = productPropertyRepository;
        }

        public IResult Add(ProductProperty productProperty)
        {
            _ProductPropertyRepository.Add(productProperty);
            return new SuccessResult(Messages.ProductPropertyAdded);
        }
        public IResult Update(ProductProperty productProperty)
        {
            _ProductPropertyRepository.Update(productProperty);
            return new SuccessResult(Messages.ProductPropertyUpdated);
        }

        public IResult Delete(ProductProperty productProperty)
        {
            _ProductPropertyRepository.Delete(productProperty);
            return new SuccessResult(Messages.ProductPropertyDeleted);
        }

        public IDataResult<List<ProductProperty>> GetAll()
        {
            return new SuccessDataResult<List<ProductProperty>>(_ProductPropertyRepository.GetAll());
        }

        public IDataResult<ProductProperty> GetById(int ProductPropertyId)
        {
            return new SuccessDataResult<ProductProperty>(_ProductPropertyRepository.Get(p => p.ID == ProductPropertyId));

        }

    }
}
