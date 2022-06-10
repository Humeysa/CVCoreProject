using CVCore.Business.Concrete;
using CVCore.DataAccsess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CVCore.UI.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new TestimonialRepository());

        public IViewComponentResult Invoke()
        {
            var result = testimonialManager.TGetList();
            return View(result);
        }
    }
}
