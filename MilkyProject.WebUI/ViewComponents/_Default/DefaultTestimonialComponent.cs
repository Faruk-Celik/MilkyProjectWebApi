﻿using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.TestimonialDto;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents._Default
{
    public class DefaultTestimonialComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultTestimonialComponent ( IHttpClientFactory httpClientFactory )
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync ()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
