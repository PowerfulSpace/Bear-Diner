using Microsoft.AspNetCore.Mvc;

namespace PS.BearDiner.Api.Controllers
{
    public class DinnersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
