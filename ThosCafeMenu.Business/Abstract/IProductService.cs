using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Core.Utilities.Results;
using ThosCafeMenu.Entity;
using ThosCafeMenu.Entity.DTOs;

namespace ThosCafeMenu.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails(int productId);
        IDataResult<List<ProductListDto>> GetProductList();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
