using EducationPortal.Business.Abstract;
using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Concrete
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;

        public AuthenticationService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public Task<CustomResponseDto<TokenDto>> CreateToken(LoginDto login)
        {
            throw new NotImplementedException();
        }
    }
}
