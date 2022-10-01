using Microsoft.AspNetCore.Mvc;

namespace samPharma.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
