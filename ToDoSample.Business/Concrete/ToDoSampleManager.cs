using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoSample.Business.Abstract;
using ToDoSample.DataAccess.Abstract.Interfaces;

namespace ToDoSample.Business.Concrete
{
    public class ToDoSampleManager : IToDoSampleService
    {
        private readonly IToDoSampleRepository _repository;

        public ToDoSampleManager(IToDoSampleRepository repository)
        {
            _repository = repository;
        }




        public void Create(Entities.Concrete.ToDoSample entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            var deletedData = _repository.GetByFilter(x => x.Id == id);
            _repository.Delete(deletedData);
        }

        public List<Entities.Concrete.ToDoSample> GetAll()
        {
            return _repository.GetAllByFilter(x => x.Title!=null);
        }

        public Entities.Concrete.ToDoSample GetById(int id)
        {
            return _repository.GetByFilter(x => x.Id == id);
        }

        public Entities.Concrete.ToDoSample GetByTitle(string title)
        {
            return _repository.GetByFilter(x => x.Title == title);
        }

        public void Update(Entities.Concrete.ToDoSample entity)
        {
            _repository.Update(entity);
        }
    }
}
