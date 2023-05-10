using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    
    public class AdminMessageController : Controller
    {
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverBox()
        {
            string p;
            p = "sühos@gmail.com";
            var values = messageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderBox()
        {
            string p;
            p = "sühos@gmail.com";
            var values = messageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = messageManager.TGetByID(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            var values = messageManager.TGetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction("ReceiverBox");
        }

        [HttpGet]
        public IActionResult AdminMessageAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageAdd(WriterMessage p)
        {
            p.Sender = "sühos@gmail.com";
            p.SenderName = "Süheyla Ustael";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(s => s.Name + " " + s.SurName).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            messageManager.TAdd(p);
            return RedirectToAction("SenderBox");
        }


    }
}
