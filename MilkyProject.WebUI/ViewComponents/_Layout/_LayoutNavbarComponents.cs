using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents._Layout
{
    public class _LayoutNavbarComponents : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
