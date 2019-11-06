using Microsoft.AspNetCore.Mvc;
using NetModular.Lib.Module.AspNetCore.Attributes;

namespace NetModular.Module.Admin.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/home")]
        [DisableAuditing]
        public IActionResult Index()
        {
            return View();
        }
    }
}
