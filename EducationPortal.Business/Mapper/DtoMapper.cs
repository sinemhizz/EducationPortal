using AutoMapper;
using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Mapper
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<ListUserDto, User>().ReverseMap();
            CreateMap<CreateEducationDto, Education>().ReverseMap();
            CreateMap<ListEducationDto, Education>().ReverseMap();
            CreateMap<UpdateEducationDto, Education>().ReverseMap();
        }
    }
}
