using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoSample.Entities.Abstract.Interfaces;

namespace ToDoSample.DataAccess.Abstract.Interfaces
{
    public interface IGenericRepository<TEntity> 
        where TEntity : class, ITable, new()
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAllByFilter(Expression<Func<TEntity, bool>> filter);
        TEntity GetByFilter(Expression<Func<TEntity, bool>> filter);
    }
}
