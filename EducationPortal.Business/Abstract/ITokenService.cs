using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Abstract
{
    public interface ITokenService
    {
        Task<TokenDto> CreateToken(User user);
    }
}
