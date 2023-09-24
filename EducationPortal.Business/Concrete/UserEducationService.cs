using EducationPortal.Business.Abstract;
using EducationPortal.Business.Mapper;
using EducationPortal.DataAccess.Abstract;
using EducationPortal.DataAccess.Concrete;
using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Concrete
{
    public class UserEducationService : IUserEducationService
    {
        private readonly IUserEducationDal _userEducationDal;

        public UserEducationService(IUserEducationDal userEducationDal)
        {
            _userEducationDal = userEducationDal;
        }

        public async Task<CustomResponseDto<CreateUserEducationDto>> CreateUserEducation(CreateUserEducationDto createUserEducationDto)
        {
            var dto = ObjectMapper.Mapper.Map<UserEducation>(createUserEducationDto);

            await _userEducationDal.AddAsync(dto);
            return CustomResponseDto<CreateUserEducationDto>.Success(200);
        }

        public async Task<CustomResponseDto<List<CreateUserEducationDto>>> GetUserEducation()
        {
            var user = await _userEducationDal.GetAll().ToListAsync();
            var dto = ObjectMapper.Mapper.Map<List<CreateUserEducationDto>>(user);
            return CustomResponseDto<List<CreateUserEducationDto>>.Success(200, dto);
        }
    }
}
