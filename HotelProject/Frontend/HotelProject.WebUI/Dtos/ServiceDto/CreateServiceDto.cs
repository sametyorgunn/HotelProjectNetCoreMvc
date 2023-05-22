using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="servis resmi linki girin")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage ="servis başlığı giriniz")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
