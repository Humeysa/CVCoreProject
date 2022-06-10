using CVCore.Business.Concrete;
using CVCore.DataAccsess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CVCore.UI.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new ContactRepository());

        public IViewComponentResult Invoke()
        {
            var result = contactManager.TGetList();
            return View(result);
        }
    }
}
