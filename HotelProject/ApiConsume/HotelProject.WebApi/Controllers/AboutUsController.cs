using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutusService;

        public AboutUsController(IAboutUsService aboutusService)
        {
            _aboutusService = aboutusService;
        }

        [HttpGet]
        public IActionResult GetAboutUsList()
        {
            var about = _aboutusService.TGetList();
            return Ok(about);
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUs(int id)
        {
            var aboutus = _aboutusService.TGetById(id);
            return Ok(aboutus);
        }
        [HttpPost]
        public IActionResult AddAboutUs(AboutUs aboutus)
        {
            _aboutusService.TInsert(aboutus);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutUs(AboutUs aboutus)
        {
            _aboutusService.TUpdate(aboutus);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAboutUs(int id)
        {
            var aboutus = _aboutusService.TGetById(id);
            _aboutusService.TDelete(aboutus);
            return Ok();
        }
        
        //public IActionResult GetAboutUsOne()
        //{
        //    var about = _aboutusService.GetAboutUs();
        //    return Ok(about);
        //}
    }
}
