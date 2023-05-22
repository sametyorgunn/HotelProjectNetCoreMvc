using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Service
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat giriniz!")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
