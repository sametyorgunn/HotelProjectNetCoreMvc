using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AdminSubscribeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminSubscribeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:55763/api/Subcribe");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SubscribeResultDto>>(jsondata);
                return View(values);
            }
            return View();
        }
        public IActionResult AddSubscribe()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSubscribe(AddSubscribeDto subscribe)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(subscribe);
            StringContent stringcontent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responsemessage = await client.PostAsync("http://localhost:55763/api/Subcribe", stringcontent);
            if (responsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteSubscribe(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.DeleteAsync($"http://localhost:55763/api/Subcribe/{id}");
            if (responsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> UpdateSubscribe(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync($"http://localhost:55763/api/Subcribe/{id}");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<UpdateSubscribeDto>(jsondata);
                return View(data);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSubscribe(UpdateSubscribeDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responsemessage = await client.PutAsync("http://localhost:55763/api/Subcribe", content);
            if (responsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
