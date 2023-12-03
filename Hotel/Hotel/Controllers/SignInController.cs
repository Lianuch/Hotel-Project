using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
