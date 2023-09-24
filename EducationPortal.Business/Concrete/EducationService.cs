using AutoMapper.Internal.Mappers;
using EducationPortal.Business.Abstract;
using EducationPortal.Business.Mapper;
using EducationPortal.DataAccess.Abstract;
using EducationPortal.DataAccess.Concrete;
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
    public class EducationService : IEducationService
    {
        private readonly IEducationDal _educationDal;

        public EducationService(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public async Task<CustomResponseDto<Education>> CreateEducation(CreateEducationDto createEducationDto)
        {
            var dto = ObjectMapper.Mapper.Map<Education>(createEducationDto);

            await _educationDal.AddAsync(dto);
            dto.CreatedDate = DateTime.Now;
            dto.ModifiedDate = DateTime.Now;
            return CustomResponseDto<Education>.Success(200);
        }

        public async Task<CustomResponseDto<List<ListEducationDto>>> GetAll()
        {
            var user = await _educationDal.GetAll().ToListAsync();
            var dto = ObjectMapper.Mapper.Map<List<ListEducationDto>>(user);
            return CustomResponseDto<List<ListEducationDto>>.Success(200, dto);
        }

        public async Task<CustomResponseDto<ListEducationDto>> GetById(int id)
        {

            var user = await _educationDal.GetByIdAsync(id);
            if (user == null)
            {
                return CustomResponseDto<ListEducationDto>.Fail(400, "Eğitim bulunamadı.");
            }
            var result = ObjectMapper.Mapper.Map<ListEducationDto>(user);
            return CustomResponseDto<ListEducationDto>.Success(200, result);
        }

        public async Task<CustomResponseDto<UpdateEducationDto>> UpdateEducation(UpdateEducationDto updateEducationDto)
        {
            var user = await _educationDal.AnyAsync(x => x.Id == updateEducationDto.Id);
            if (!user)
            {
                return CustomResponseDto<UpdateEducationDto>.Fail(400, "Eğitim bulunamadı.");
            }
            var updateEducation = new Education
            {
               CategoryName = updateEducationDto.CategoryName,
               Content = updateEducationDto.Content,
               Cost = updateEducationDto.Cost,
               QuatoCount = updateEducationDto.QuatoCount,
               Teacher = updateEducationDto.Teacher,
               Time = updateEducationDto.Time,
               ModifiedDate= DateTime.Now
            };
            _educationDal.Update(updateEducation);
            return CustomResponseDto<UpdateEducationDto>.Success(200);
        }
    }
}
