using HotelProject.WebUI.Dtos.TestimonialDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class TestimonialComponent:ViewComponent
    {
        private readonly IHttpClientFactory _clientFactory;

        public TestimonialComponent(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _clientFactory.CreateClient();
            var responsemessage = await client.GetAsync("http://localhost:55763/api/Testimonial");
            if (responsemessage.IsSuccessStatusCode)
            {
                var content = await responsemessage.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<TestimonialResultDto>>(content);
                return View(datas);
            }
            return View();
        }
    }
}
