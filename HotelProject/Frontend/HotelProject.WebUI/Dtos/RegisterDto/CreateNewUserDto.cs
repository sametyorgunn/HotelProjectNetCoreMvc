using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="İsim girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyİsim girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail girin")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Sifre girin")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
