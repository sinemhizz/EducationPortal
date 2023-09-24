using EducationPortal.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Abstract
{
    public interface IUserEducationService
    {
        Task<CustomResponseDto<CreateUserEducationDto>> CreateUserEducation(CreateUserEducationDto createUserEducationDto);
        Task<CustomResponseDto<List<CreateUserEducationDto>>> GetUserEducation();
    }
}
