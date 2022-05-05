using CVCore.Business.Concrete;
using CVCore.DataAccsess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CVCore.UI.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new ServiceRepository());

        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
    }
}
