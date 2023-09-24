using EducationPortal.DataAccess.Abstract;
using EducationPortal.DataAccess.Services;
using EducationPortal.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.DataAccess.Concrete
{
    public class EducationDal : GenericService<Education>, IEducationDal
    {
        public EducationDal(AppDbContext context) : base(context)
        {
        }
    }
}
