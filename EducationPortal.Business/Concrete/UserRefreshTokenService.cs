using EducationPortal.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Concrete
{
    public class UserRefreshTokenService:IUserRefreshTokenService
    {
        private readonly IUserRefreshTokenService _userRefreshTokenService;

        public UserRefreshTokenService(IUserRefreshTokenService userRefreshTokenService)
        {
            _userRefreshTokenService = userRefreshTokenService;
        }
    }
}
