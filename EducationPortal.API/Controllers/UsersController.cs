using EducationPortal.Business.Abstract;
using EducationPortal.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetAllUser();
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _userService.GetById(id);
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
        [HttpPost("add")]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
        {
            var result = await _userService.CreateUser(createUserDto);
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser(UpdateUserDto updateUserDto)
        {
            var result = await _userService.UpdateUser(updateUserDto);
            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
    }
}
