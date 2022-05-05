using CVCore.Business.Concrete;
using CVCore.DataAccsess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CVCore.UI.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new AboutRepository());

        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }

    }
}
