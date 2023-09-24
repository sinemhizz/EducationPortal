using EducationPortal.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.DataAccess.Configuration
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName).IsRequired();
            builder.Property(x => x.Teacher).IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.ModifiedDate).HasDefaultValueSql("GETDATE()");

            builder.ToTable("Educations");

            builder.HasData(
                new Education { Id = 1, CategoryName = "Makale", Teacher = "İç Eğitmen", QuatoCount = 100,Time ="05:00", Cost = 1500, Content = "default" });
        }
    }
}
