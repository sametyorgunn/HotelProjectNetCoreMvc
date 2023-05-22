using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBookingController : Controller
    {
        private readonly IHttpClientFactory _httpclientfactory;

        public AdminBookingController(IHttpClientFactory httpclientfactory)
        {
            _httpclientfactory = httpclientfactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpclientfactory.CreateClient();
            var responsemessage = await client.GetAsync("http://localhost:55763/api/Booking");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<BookingResultDto>>(jsondata);
                return View(data);
            }
            return View();
        }
        public async Task<IActionResult> DoActiveBooking(int id)
        {
            var client = _httpclientfactory.CreateClient();
            StringContent content = new StringContent("", Encoding.UTF8, "application/json");

            var responsemessage = await client.PutAsync($"http://localhost:55763/api/Booking/{id}/DoActive",content);
            if (responsemessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/AdminBooking/Index");
            }
            return View();

            

        }
        public async Task<IActionResult> DoPasiveBooking(int id)
        {
            var client = _httpclientfactory.CreateClient();
            StringContent content = new StringContent("", Encoding.UTF8, "application/json");

            var responsemessage = await client.PutAsync($"http://localhost:55763/api/Booking/{id}/DoPasive", content);
            if (responsemessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/AdminBooking/Index");
            }
            return View();



        }
    }
}
