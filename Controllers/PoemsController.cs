using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class PoemsController : Controller
    {
        public IActionResult Index()
        {
          return View();
        }
    }
}
