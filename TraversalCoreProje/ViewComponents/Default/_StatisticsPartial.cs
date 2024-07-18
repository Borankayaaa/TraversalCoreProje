using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count(); // viewbag 1
            ViewBag.v2 = c.Guides.Count();   // viewbag 2
            ViewBag.v3 = "285";   // viewbag 3
            return View();
        }
    }
}
