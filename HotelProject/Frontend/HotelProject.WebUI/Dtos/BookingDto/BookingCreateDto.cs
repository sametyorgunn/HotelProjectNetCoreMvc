using System;

namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class BookingCreateDto
    {
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
