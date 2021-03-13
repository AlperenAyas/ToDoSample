using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoSample.DataAccess.Abstract.Interfaces;
using ToDoSample.DataAccess.Concrete.EfCore.Context;

namespace ToDoSample.DataAccess.Concrete.EfCore.Repository
{
    public class ToDoSampleRepository : GenericRepository<ToDoSample.Entities.Concrete.ToDoSample>, IToDoSampleRepository
    {
        private readonly ToDoSampleContext _context;

        public ToDoSampleRepository(ToDoSampleContext context):base(context)
        {
            _context = context;
        }
    }
}
