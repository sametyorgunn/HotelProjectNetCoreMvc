using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpclientfactory;

        public BookingController(IHttpClientFactory httpclientfactory)
        {
            _httpclientfactory = httpclientfactory;
        }

        public IActionResult Index()
        {
            return View();
        }
     
        public PartialViewResult CreateBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBooking(BookingCreateDto dto)
        {
            dto.Status = 0;
            dto.Description = "0";
            var client = _httpclientfactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(dto);
            StringContent content = new StringContent(jsondata,Encoding.UTF8,"application/json");
            var responsemessage = await client.PostAsync("http://localhost:55763/api/Booking", content);
            if (responsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
