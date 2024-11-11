using Microsoft.AspNetCore.Mvc;

namespace CarouselTagHelper.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
