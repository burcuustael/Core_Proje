using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult NewSideBar()
        {
            return PartialView();
        }

    }
}
