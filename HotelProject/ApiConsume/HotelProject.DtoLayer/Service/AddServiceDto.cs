using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Service
{
    public class AddServiceDto
    {
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Lütfen başlık giriniz!")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
