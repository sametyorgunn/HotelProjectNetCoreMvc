using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "servis resmi linki girin")]

        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "servis baslıgı girin")]

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
