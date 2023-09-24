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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Email).IsRequired();
            builder.Property(x=>x.UserName).IsRequired();

            builder.HasData(
                new User { Id = "E06455D", FirstName = "Sinem", LastName = "Hız", Email = "sinemhiz66@gmail.com", UserName = "sinem.hiz" });
        }
    }
}
