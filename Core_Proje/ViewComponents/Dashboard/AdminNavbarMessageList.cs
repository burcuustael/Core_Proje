using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager writerMessage = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "sühos@gmail.com";
            var values = writerMessage.GetListReceiverMessage(p).OrderByDescending(x=>x.Id).Take(3).ToList();
            return View(values);
        }
    }
}
