using CVCore.Business.Concrete;
using CVCore.DataAccsess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CVCore.UI.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new ExperienceRepository());

        public IViewComponentResult Invoke()
        {
            var result = experienceManager.TGetList();
            return View(result);
        }
    }
}
