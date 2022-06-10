using Microsoft.AspNetCore.Mvc;

namespace CVCore.UI.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
