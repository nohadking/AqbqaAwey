using Microsoft.AspNetCore.Mvc;

namespace AqbqaAwey.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AcccuontController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
