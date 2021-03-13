using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoSample.DataAccess.Concrete.EfCore.Configurations;

namespace ToDoSample.DataAccess.Concrete.EfCore.Context
{
    public class ToDoSampleContext : DbContext
    {

        public DbSet<ToDoSample.Entities.Concrete.ToDoSample> ToDoSamples { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-68G1D2B;Database=ToDoSample;User Id=sa;Password=1;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ToDoSampleConfiguration());
        }
    }
}
