using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.TeamDto;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents._Default
{
    public class DefaultTeamComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultTeamComponent ( IHttpClientFactory httpClientFactory )
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync ()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Team");
            if (responseMessage != null)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTeamDto>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
