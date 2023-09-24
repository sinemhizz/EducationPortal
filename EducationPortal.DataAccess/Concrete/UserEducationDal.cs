using EducationPortal.DataAccess.Abstract;
using EducationPortal.DataAccess.Services;
using EducationPortal.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.DataAccess.Concrete
{
    public class UserEducationDal : GenericService<UserEducation>, IUserEducationDal
    {
        public UserEducationDal(AppDbContext context) : base(context)
        {
        }
    }
}
