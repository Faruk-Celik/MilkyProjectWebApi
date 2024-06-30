using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.AdressDto;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents._Layout
{
    public class _LayoutFooterComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _LayoutFooterComponent ( IHttpClientFactory httpClientFactory )
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync ()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Adress");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAdressDto>>(jsonData);
                return View(values.FirstOrDefault());
            }

            return View();
        }
    }
}
