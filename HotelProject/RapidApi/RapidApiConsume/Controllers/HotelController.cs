using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;
using RapidApiConsume.Models;
using System.Linq;

namespace RapidApiConsume.Controllers
{
    public class HotelController : Controller
    {
        public async Task<IActionResult> Index()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?checkin_date=2023-05-12&dest_type=city&units=metric&checkout_date=2023-05-15&adults_number=2&order_by=popularity&dest_id=-755070&filter_by_currency=TRY&locale=en-gb&room_number=1&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&include_adjacency=true"),
                Headers =
            {
                { "X-RapidAPI-Key", "7e7f806d68mshed0a2350fcb87b9p1d99c2jsn7d714f252e40" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<HotelGetListViewModel>(body);
                return View(datas.result.ToList());
            }
        }
        public async Task<IActionResult> SearchLocationId(string CityName)
        {
            if (!string.IsNullOrEmpty(CityName))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={CityName}&locale=en-gb"),
                    Headers =
            {
                { "X-RapidAPI-Key", "7e7f806d68mshed0a2350fcb87b9p1d99c2jsn7d714f252e40" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<HotelSearchIdViewModel>>(body);
                    return View(data.Take(1).ToList());
                }
                return View();
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=paris&locale=en-gb"),
                    Headers =
            {
                { "X-RapidAPI-Key", "7e7f806d68mshed0a2350fcb87b9p1d99c2jsn7d714f252e40" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<HotelSearchIdViewModel>>(body);
                    return View(data.Take(1).ToList());
                }
                return View();
            }
        }
        public async Task<IActionResult> SearchHotelById(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/search?checkin_date=2023-05-12&dest_type=city&units=metric&checkout_date=2023-05-15&adults_number=2&order_by=popularity&dest_id={id}&filter_by_currency=TRY&locale=en-gb&room_number=1&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&include_adjacency=true"),
                    Headers =
            {
                { "X-RapidAPI-Key", "7e7f806d68mshed0a2350fcb87b9p1d99c2jsn7d714f252e40" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var datas = JsonConvert.DeserializeObject<HotelGetListViewModel>(body);
                    return View(datas.result.ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?checkin_date=2023-05-12&dest_type=city&units=metric&checkout_date=2023-05-15&adults_number=2&order_by=popularity&dest_id=-755070&filter_by_currency=TRY&locale=en-gb&room_number=1&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&include_adjacency=true"),
                    Headers =
            {
                { "X-RapidAPI-Key", "7e7f806d68mshed0a2350fcb87b9p1d99c2jsn7d714f252e40" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var datas = JsonConvert.DeserializeObject<HotelGetListViewModel>(body);
                    return View(datas.result.ToList());
                }
            }
           
        }
    }
}
