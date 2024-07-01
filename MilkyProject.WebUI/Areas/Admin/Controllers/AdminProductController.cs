using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.AdressDto;
using MilkyProject.WebUI.Dtos.ProductDto;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminProductController ( IHttpClientFactory httpClientFactory )
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> AdminProductList ()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Product/GetProductWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAdminProduct ( int id )
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Product/GetProduct?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAdminProduct ( UpdateProductDto updateProductDto )
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/Product", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminProductList");
            }
            return View();
        }

        public async Task<IActionResult> DeleteAdminProduct ( int id )
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7184/api/Product?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminProductList");
            }
            return View();
        }
        
        [HttpGet]
        public async Task<IActionResult> CreateAdminProduct ()
        {
            return View();
        }
        [HttpPost]  
        public async Task<IActionResult> CreateAdminProduct ( CreateProductDto createProductDto)
        {
            var client = _httpClientFactory.CreateClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(createProductDto), Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/Product",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
               return RedirectToAction("Index");
            }
            return View();
        }
    }
}
