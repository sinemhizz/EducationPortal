using EducationPortal.Business.Abstract;
using EducationPortal.Business.Mapper;
using EducationPortal.DataAccess.Abstract;
using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserDal _userDal;

        public UserService(UserManager<User> userManager, IUserDal userDal)
        {
            _userManager = userManager;
            _userDal = userDal;
        }

        public async Task<CustomResponseDto<CreateUserDto>> CreateUser(CreateUserDto createUserDto)
        {
            var user = new User
            {
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                Email = createUserDto.Email,
                UserName = createUserDto.UserName,
            };
            var result = await _userManager.CreateAsync(user, createUserDto.Password);
            if(!result.Succeeded)
            {
                return CustomResponseDto<CreateUserDto>.Fail(400, "Bir hata ile karşılaşıldı.");
            }
            return CustomResponseDto<CreateUserDto>.Success(200);
        }

        public async Task<CustomResponseDto<List<ListUserDto>>> GetAllUser()
        {
            var user =await _userDal.GetAll().ToListAsync();
            var dto = ObjectMapper.Mapper.Map<List<ListUserDto>>(user);
            return CustomResponseDto<List<ListUserDto>>.Success(200,dto);
        }

        public async Task<CustomResponseDto<ListUserDto>> GetById(string id)
        {
            var user = await _userDal.GetByUserIdAsync(id);
            if(user == null)
            {
                return CustomResponseDto<ListUserDto>.Fail(400, "Kullanıcı bulunamadı.");
            }
            var result = ObjectMapper.Mapper.Map<ListUserDto>(user);
            return CustomResponseDto<ListUserDto>.Success(200, result);
        }

        public async Task<CustomResponseDto<UpdateUserDto>> UpdateUser(UpdateUserDto updateUserDto)
        {
            var user = await _userDal.AnyAsync(x=>x.Id == updateUserDto.Id);
            if (!user)
            {
                return CustomResponseDto<UpdateUserDto>.Fail(400, "Kullanıcı bulunamadı.");
            }
            var updateUser = new User
            {
                FirstName = updateUserDto.FirstName,
                LastName = updateUserDto.LastName,
                Email = updateUserDto.Email,
            };
            if(updateUserDto.Password != null)
            {
                var code = await _userManager.GeneratePasswordResetTokenAsync(updateUser);
                await _userManager.ResetPasswordAsync(updateUser, code, updateUserDto.Password);
            }
            var result = await _userManager.UpdateAsync(updateUser);
            return CustomResponseDto<UpdateUserDto>.Success(200);
        }
    }
}
