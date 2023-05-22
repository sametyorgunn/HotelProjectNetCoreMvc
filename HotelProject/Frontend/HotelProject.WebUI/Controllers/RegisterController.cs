using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RegisterController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appuser = new AppUser
            {
                Name = dto.Name,
                Surname= dto.Surname,
                Email = dto.Mail,
                UserName = dto.UserName   
            };
            var result = await _userManager.CreateAsync(appuser, dto.Password);
            
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            return View();
        }
    }
}
