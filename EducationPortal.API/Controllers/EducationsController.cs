using EducationPortal.Business.Abstract;
using EducationPortal.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        private readonly IEducationService _educationService;

        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _educationService.GetAll();
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _educationService.GetById(id);
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
        [HttpPost("add")]
        public async Task<IActionResult> CreateEducation(CreateEducationDto createEducationDto)
        {
            var result = await _educationService.CreateEducation(createEducationDto);
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateEducation(UpdateEducationDto updateEducationDto)
        {
            var result = await _educationService.UpdateEducation(updateEducationDto);
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
    }
}
