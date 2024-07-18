using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestinationPartial : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new  EfDestinationDal()); // BUNUN ÇALIŞMA PRENSİBİNİ ÖĞREN
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.GetList();
            return View(values);
        }
    }
}
