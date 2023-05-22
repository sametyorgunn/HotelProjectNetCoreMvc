using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.TestimonialDto
{
    public class AddTestimonialDto
    {
        [Required(ErrorMessage = "Lütfen isim giriniz!")]
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
