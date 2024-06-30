using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.WhyUsDto;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents._Default
{
    public class DefaultWhyUsComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultWhyUsComponent ( IHttpClientFactory httpClientFactory )
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync ()
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
    
    }
}
