using Microsoft.AspNetCore.Mvc;

namespace Nafima.UI.Controllers
{
    public class DonationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
