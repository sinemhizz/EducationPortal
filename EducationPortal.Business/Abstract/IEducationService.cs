using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Abstract
{
    public interface IEducationService
    {
        Task<CustomResponseDto<Education>> CreateEducation(CreateEducationDto createEducationDto);
        Task<CustomResponseDto<UpdateEducationDto>> UpdateEducation(UpdateEducationDto updateEducationDto);
        Task<CustomResponseDto<List<ListEducationDto>>> GetAll();
        Task<CustomResponseDto<ListEducationDto>> GetById(int id);
    }
}
