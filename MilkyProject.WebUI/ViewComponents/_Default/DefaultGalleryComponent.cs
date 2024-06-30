using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents._Default
{
    public class DefaultGalleryComponent : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
