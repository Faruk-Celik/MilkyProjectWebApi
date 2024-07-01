using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.WhyUsDto;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminWhyUsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminWhyUsController ( IHttpClientFactory httpClientFactory )
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> AdminWhyUsList ()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/WhyUs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhyUsDto>>(jsonData);
                return View(values);
            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> AdminUpdateWhyUs ( int id )
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/WhyUs/GetWhyUs?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateWhyUsDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdminUpdateWhyUs ( UpdateWhyUsDto updateWhyUsDto )
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateWhyUsDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/WhyUs", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminWhyUsList");
            }
            return View();
        }
    }
}
