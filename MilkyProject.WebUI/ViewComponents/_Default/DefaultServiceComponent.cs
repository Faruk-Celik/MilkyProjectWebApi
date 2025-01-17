﻿using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.ServiceDto;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents._Default
{
    public class DefaultServiceComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultServiceComponent ( IHttpClientFactory httpClientFactory )
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync ()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
