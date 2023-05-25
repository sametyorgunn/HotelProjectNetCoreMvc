using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;

		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
		}

		[HttpGet]
		public IActionResult GetRoomList()
		{
			var rooms = _roomService.TGetList();
			return Ok(rooms);
		}
		[HttpGet("{id}")]
		public IActionResult GetRoom(int id)
		{
			var room = _roomService.TGetById(id);
			return Ok(room);
		}
		[HttpPost]
		public IActionResult AddRoom(Room room)
		{
			_roomService.TInsert(room);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.TUpdate(room);
			return Ok();
		}
		[HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var room = _roomService.TGetById(id);
            _roomService.TDelete(room);
            return Ok();
        }

		[HttpPost("imageupload")]
		public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
		{
			var filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
			var path = Path.Combine(Directory.GetCurrentDirectory(), "images/" + filename);
			var stream = new FileStream(path, FileMode.Create);
			await file.CopyToAsync(stream);
			return Created("",file);
		}
    }
}
