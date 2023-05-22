using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		private readonly IStaffService _staffService;

		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
		public IActionResult GetStaffList()
		{
			var staffs = _staffService.TGetList();
			return Ok(staffs);
		}
		[HttpGet("{id}")]
		public IActionResult GetStaff(int id)
		{
			var staff = _staffService.TGetById(id);
			return Ok(staff);
		}
		[HttpPost]
		public IActionResult AddStaff(Staff staff)
		{
			_staffService.TInsert(staff);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.TUpdate(staff);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteStaff(int id)
		{
			var staff = _staffService.TGetById(id);
			_staffService.TDelete(staff);
			return Ok();
		}
	}
}
