using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.ProductDto;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProject.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
