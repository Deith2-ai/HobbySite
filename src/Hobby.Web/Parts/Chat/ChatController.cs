using System.Web.Mvc;

namespace Hobby.Web.Parts.Chat
{
    public class ChatController : BaseController
    {
        // GET: Chat
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}