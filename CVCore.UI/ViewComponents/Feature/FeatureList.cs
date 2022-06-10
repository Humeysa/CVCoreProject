using CVCore.Business.Concrete;
using CVCore.DataAccsess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CVCore.UI.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new FeatureRepository());

        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
