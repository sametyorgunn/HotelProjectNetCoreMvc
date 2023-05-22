using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _TestimonialService;

		public TestimonialController(ITestimonialService TestimonialService)
		{
			_TestimonialService = TestimonialService;
		}

		[HttpGet]
		public IActionResult GetTestimonialList()
		{
			var Testimonials = _TestimonialService.TGetList();
			return Ok(Testimonials);
		}
		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var Testimonial = _TestimonialService.TGetById(id);
			return Ok(Testimonial);
		}
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_TestimonialService.TInsert(testimonial);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_TestimonialService.TUpdate(testimonial);
			return Ok();
		}
		[HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var testimonial = _TestimonialService.TGetById(id);
            _TestimonialService.TDelete(testimonial);
            return Ok();
        }
    }
}
