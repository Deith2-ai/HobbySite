using Hobby.Web.Authorize;
using System.Web.Mvc;

namespace Hobby.Web.Parts
{
    public class BaseController : Controller
    {
        protected virtual new CustomPrincipal User
        {
            get { return HttpContext.User as CustomPrincipal; }
        }
    }
}