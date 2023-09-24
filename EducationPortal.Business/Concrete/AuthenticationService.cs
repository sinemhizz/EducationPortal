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
        private readonly ITokenService _tokenService;

        public AuthenticationService(UserManager<User> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        public async Task<CustomResponseDto<TokenDto>> CreateToken(LoginDto login)
        {
            if (login == null) throw new ArgumentNullException(nameof(login));

            var user = await _userManager.FindByEmailAsync(login.Email);

            if (user == null) return  CustomResponseDto<TokenDto>.Fail(400,"Email veya şifre yanlış girildi.");

            if (!await _userManager.CheckPasswordAsync(user, login.Password)) return CustomResponseDto<TokenDto>.Fail(400, "Email veya şifre yanlış girildi.");

            var token = await _tokenService.CreateToken(user);

            return CustomResponseDto<TokenDto>.Success(200, token);
        }
    }
}
