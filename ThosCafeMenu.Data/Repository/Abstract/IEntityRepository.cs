using System;
using ThosCafeMenu.Entity;
using System.Linq.Expressions;
using System.Collections.Generic; 

namespace ThosCafeMenu.Data.Repository.Abstract
{
     
    public interface IEntityRepository<T> where T : class,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter); 
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity); 
    }
}
