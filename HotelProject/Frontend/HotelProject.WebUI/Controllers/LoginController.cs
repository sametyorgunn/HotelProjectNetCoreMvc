using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto dto)
        {
            if (ModelState.IsValid)
            {
                var giris = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, true, false);
                if(giris.Succeeded)
                {
                    return RedirectToAction("Panel", "PanelController");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
            
        }
    }
}
