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
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IResult Add(Category category)
        {
            _categoryRepository.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }
        public IResult Update(Category category)
        {
            _categoryRepository.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IResult Delete(Category category)
        {
            _categoryRepository.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryRepository.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryRepository.Get(p => p.ID == categoryId));

        }

    }
}
