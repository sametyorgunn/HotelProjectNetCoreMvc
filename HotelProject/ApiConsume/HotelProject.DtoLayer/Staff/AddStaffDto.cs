using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Staff
{
    public class AddStaffDto
    {
        [Required(ErrorMessage = "Lütfen isim giriniz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen ünvan giriniz!")]
        public string Title { get; set; }
        public string SocialMedia1 { get; set; }
        public string SocialMedia2 { get; set; }
        public string SocialMedia3 { get; set; }
    }
}
