using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoSample.DataAccess.Abstract.Interfaces
{
    public interface IToDoSampleRepository : IGenericRepository<ToDoSample.Entities.Concrete.ToDoSample>
    {
    }
}
