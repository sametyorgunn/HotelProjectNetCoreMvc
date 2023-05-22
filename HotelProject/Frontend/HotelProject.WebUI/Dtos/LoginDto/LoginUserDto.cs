using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı adınızı girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Şifrenizi Girin")]
        public string Password { get; set; }
    }
}
