using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoSample.DataAccess.Concrete.EfCore.Configurations
{
    public class ToDoSampleConfiguration : IEntityTypeConfiguration<ToDoSample.Entities.Concrete.ToDoSample>
    {
        public void Configure(EntityTypeBuilder<Entities.Concrete.ToDoSample> builder)
        {
            builder.ToTable("Todos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("GetDate()");

            builder.Property(x => x.Description).IsRequired(false);

            builder.Property(x => x.Title).IsRequired(false);
            builder.Property(x => x.Title).HasMaxLength(50);

            builder.Property(x => x.Status).IsRequired();
        }
    }
}
