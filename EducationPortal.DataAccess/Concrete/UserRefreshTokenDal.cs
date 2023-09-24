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
    public class UserRefreshTokenDal : GenericService<UserRefreshToken>, IUserRefreshTokenDal
    {
        public UserRefreshTokenDal(AppDbContext context) : base(context)
        {
        }
    }
}
