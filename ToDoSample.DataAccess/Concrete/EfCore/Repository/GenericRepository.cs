using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoSample.DataAccess.Abstract.Interfaces;
using ToDoSample.DataAccess.Concrete.EfCore.Context;
using ToDoSample.Entities.Abstract.Interfaces;

namespace ToDoSample.DataAccess.Concrete.EfCore.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, ITable, new()
    {
        private readonly ToDoSampleContext _context;

        public GenericRepository(ToDoSampleContext context)
        {
            _context = context;
        }



        public void Create(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<TEntity> GetAllByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().FirstOrDefault(filter);
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
