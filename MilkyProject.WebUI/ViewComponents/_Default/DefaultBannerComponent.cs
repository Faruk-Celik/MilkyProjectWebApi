using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents._Default
{
    public class DefaultBannerComponent : ViewComponent
    {
        public IViewComponentResult Invoke () 
        { 
            return View(); 
        }
    }
}
