using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EasyCashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
