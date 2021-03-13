using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoSample.Entities.Abstract.Interfaces;

namespace ToDoSample.Entities.Concrete
{
    public class ToDoSample : ITable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public TodoStatus Status { get; set; }
    }
}
