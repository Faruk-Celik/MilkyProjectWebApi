using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents._Layout
{
    public class _LayoutNewsLetterComponent :ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
