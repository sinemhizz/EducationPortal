using EducationPortal.Business.Abstract;
using EducationPortal.Business.Concrete;
using EducationPortal.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserEducationsController : ControllerBase
    {
        private readonly IUserEducationService _userEducationService;

        public UserEducationsController(IUserEducationService userEducationService)
        {
            _userEducationService = userEducationService;
        }
        [HttpPost("all")]
        public async Task<IActionResult> GetUserEducation()
        {
            var result = await _userEducationService.GetUserEducation();
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
        [HttpPost("add")]
        public async Task<IActionResult> CreateUserEducation(CreateUserEducationDto createUserEducationDto)
        {
            var result = await _userEducationService.CreateUserEducation(createUserEducationDto);
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
    }
}
