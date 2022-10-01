using Microsoft.AspNetCore.Mvc;

namespace samPharma.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
