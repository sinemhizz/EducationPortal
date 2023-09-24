using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Abstract
{
    public interface IUserService
    {
        Task<CustomResponseDto<CreateUserDto>> CreateUser(CreateUserDto createUserDto);
        Task<CustomResponseDto<UpdateUserDto>> UpdateUser(UpdateUserDto updateUserDto);
        Task<CustomResponseDto<List<ListUserDto>>> GetAllUser();
        Task<CustomResponseDto<ListUserDto>> GetById(string id);
    }
}
