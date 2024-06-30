using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents._Default
{
    public class DefaultSliderComponent : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
