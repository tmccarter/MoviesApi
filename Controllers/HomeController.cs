using Microsoft.AspNetCore.Mvc;

namespace MoviesApi.Controllers
{
    [Route("/home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}