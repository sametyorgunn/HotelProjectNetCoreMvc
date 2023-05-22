using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceService _ServiceService;

		public ServiceController(IServiceService ServiceService)
		{
			_ServiceService = ServiceService;
		}

		[HttpGet]
		public IActionResult GetServiceList()
		{
			var Services = _ServiceService.TGetList();
			return Ok(Services);
		}
		[HttpGet("{id}")]
		public IActionResult GetService(int id)
		{
			var Service = _ServiceService.TGetById(id);
			return Ok(Service);
		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			_ServiceService.TInsert(service);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateService(Service service)
		{
			_ServiceService.TUpdate(service);
			return Ok();
		}
		[HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var service = _ServiceService.TGetById(id);
            _ServiceService.TDelete(service);
            return Ok();
        }
    }
}
