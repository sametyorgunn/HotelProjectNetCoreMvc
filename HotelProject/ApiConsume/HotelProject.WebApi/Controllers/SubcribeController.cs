using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubcribeController : ControllerBase
	{
		private readonly ISubcribeService _SubcribeService;

		public SubcribeController(ISubcribeService SubcribeService)
		{
			_SubcribeService = SubcribeService;
		}

		[HttpGet]
		public IActionResult GetSubscribeList()
		{
			var Subscribes = _SubcribeService.TGetList();
			return Ok(Subscribes);
		}
		[HttpGet("{id}")]
		public IActionResult GetSubscribe(int id)
		{
			var Subscribe = _SubcribeService.TGetById(id);
			return Ok(Subscribe);
		}
		[HttpPost]
		public IActionResult AddSubscribe(Subscribe subscribe)
		{
			_SubcribeService.TInsert(subscribe);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateSubscribe(Subscribe subscribe)
		{
			_SubcribeService.TUpdate(subscribe);
			return Ok();
		}
		[HttpDelete]
        public IActionResult DeleteSubcribe(int id)
        {
            var subcribe = _SubcribeService.TGetById(id);
            _SubcribeService.TDelete(subcribe);
            return Ok();
        }
    }
}
