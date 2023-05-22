using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildrenCount { get; set; }
        public string RoomCount { get; set; }
        public string SpeacialRequest { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
