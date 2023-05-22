using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Service
{
    public class ServiceResultDto
    {
        public int ServiceId { get; set; }
        public string ServiceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
