using Microsoft.AspNetCore.Mvc;

namespace UoHCateringSystem.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
