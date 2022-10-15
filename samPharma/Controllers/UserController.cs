using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using samPharma.Data;
using samPharma.Models.Users;
using samPharma.ViewModel;

namespace samPharma.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult AddUser()
        {
            return View();
        }
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly samDbContext _context;
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, samDbContext samDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = samDbContext;
        }
        [HttpPost]
         public async Task<IActionResult> Login(LoginViewModel loginviewmodel)
         {
             if (!ModelState.IsValid)
             {                
                 var user = await _userManager.FindByEmailAsync(loginviewmodel.Email);
             }
             if (User!=null)
             {
                 //var passwordCheck = await _userManager.CheckPasswordAsync( loginviewmodel.Password);
             }
            return View(loginviewmodel);
         } 
    }
}
