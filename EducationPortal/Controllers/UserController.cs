using EducationPortal.Business.Abstract;
using EducationPortal.Business.Mapper;
using EducationPortal.Entities.Dtos;
using EducationPortal.Entities.Entities;
using EducationPortal.WEB.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EducationPortal.WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly UserApiService _userApiService;
        private readonly IUserService _userService;
        private readonly UserManager<User> _userManager;

        public UserController(IUserService userService, UserManager<User> userManager, UserApiService userApiService)
        {
            _userService = userService;
            _userManager = userManager;
            _userApiService = userApiService;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _userApiService.GetUser());
        }
        public async Task<IActionResult> Save(CreateUserDto userDto)
        {
            var user = new User
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                UserName = userDto.UserName,
            };
            var result = await _userManager.CreateAsync(user, userDto.Password);
            return RedirectToAction(nameof(Index));
        }
    }
}
