using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThosCafeMenu.Data.Repository.Abstract;
using ThosCafeMenu.Entity;
using ThosCafeMenu.Entity.DTOs;

namespace ThosCafeMenu.Data.Repository.Concrete
{
    public class EfProductRepository : EfEntityRepositoryBase<Product, dbContext>, IProductRepository
    {
        public List<ProductListDto> GetProductList()
        {
            using (dbContext context = new dbContext())
            {
                var result = from p in context.PRODUCT
                             join c in context.CATEGORY
                             on p.CATEGORYID equals c.ID
                             
                             select new ProductListDto
                             {
                                 ProductId = p.ID,
                                 ProductName = p.PRODUCTNAME, 
                                 CategoryId = p.CATEGORYID,
                                 CategoryName = c.CATEGORYNAME,
                                 ImageUrl = p.IMAGEPATH
                             };
                return result.ToList();
            }
        }

        public List<ProductDetailDto> GetProductDetail(int id)
        { 
            using (dbContext context = new dbContext())
            {
                var result = from p in context.PRODUCT
                             join c in context.CATEGORY on p.CATEGORYID equals c.ID
                             where p.ID == id   
                             select new ProductDetailDto
                             {
                                 ProductId = p.ID,
                                 ProductName = p.PRODUCTNAME,
                                 CategoryId = p.CATEGORYID,
                                 CategoryName = c.CATEGORYNAME
                             };
                return result.ToList();
            }
        }
    }
}
