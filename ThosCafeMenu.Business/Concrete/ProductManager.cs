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
using ThosCafeMenu.Entity.DTOs;

namespace ThosCafeMenu.Business.Concrete
{
    public  class ProductManager : IProductService
    {
        IProductRepository _productRepository;
        ICategoryService _categoryService;
        public ProductManager(IProductRepository productRepository, ICategoryService categoryService)
        {
            _productRepository = productRepository;
            _categoryService = categoryService;
        }
       
        public IResult Add(Product product)
        {
            
            _productRepository.Add(product);
            return new SuccessDataResult<Product>(product, Messages.ProductAdded);

        }
    
        public IResult Update(Product product)
        {
            _productRepository.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IResult Delete(Product product)
        {
            _productRepository.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

     
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productRepository.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productRepository.GetAll(p => p.CATEGORYID == id), Messages.ProductListed);
        }
         
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productRepository.Get(x => x.ID == productId), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productRepository.GetAll(p => p.PRICE >= min && p.PRICE <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails(int productId)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            return new DataResult<List<ProductDetailDto>>(_productRepository.GetProductDetail(productId), true);
        }
        private IResult CheckIfProductNameExists(string name)
        {
            var result = _productRepository.GetAll(p => p.PRODUCTNAME == name).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _productRepository.GetAll(p => p.CATEGORYID == categoryId).Count;
            if (result >= 15)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();
        }

        public IDataResult<List<ProductListDto>> GetProductList()
        {
            return new DataResult<List<ProductListDto>>(_productRepository.GetProductList(), true);
        }
    }
}
