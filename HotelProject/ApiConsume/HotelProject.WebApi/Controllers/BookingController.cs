using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult GetBookingList()
        {
            var booking = _bookingService.TGetList();
            return Ok(booking);
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var booking = _bookingService.TGetById(id);
            return Ok(booking);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var booking = _bookingService.TGetById(id);
            _bookingService.TDelete(booking);
            return Ok();
        }
        [HttpPut("{id}/DoActive")]
        public IActionResult BookingDoActive(int id)
        {
            var booking = _bookingService.TGetById(id);
            booking.Status = 1;
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpPut("{id}/DoPasive")]
        public IActionResult BookingDoPasive(int id)
        {
            var booking = _bookingService.TGetById(id);
            booking.Status = 0;
            _bookingService.TUpdate(booking);
            return Ok();
        }
    }
}
