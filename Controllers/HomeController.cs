using Microsoft.AspNetCore.Mvc;

namespace MoviesApi.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}