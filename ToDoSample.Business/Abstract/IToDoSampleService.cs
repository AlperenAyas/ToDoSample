using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoSample.Business.Abstract
{
    public interface IToDoSampleService
    {
        void Create(ToDoSample.Entities.Concrete.ToDoSample entity);
        void Update(ToDoSample.Entities.Concrete.ToDoSample entity);
        void Delete(int id);
        List<ToDoSample.Entities.Concrete.ToDoSample> GetAll();
        ToDoSample.Entities.Concrete.ToDoSample GetById(int id);
        ToDoSample.Entities.Concrete.ToDoSample GetByTitle(string title);
    }
}
