using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var moviesList = new List<MediaItem>
        {
            new MediaItem { Title = "Suzume", ImageUrl = "/Assets/Movies/suzume.jpg", Rating = 8.8, Description = "A fantastic anime movie.", Genre = "Romance" },
            new MediaItem { Title = "Your name", ImageUrl = "/Assets/Movies/your_name.jpg", Rating = 8.8, Description = "A lovely anime movie.", Genre = "Romance"  }
        };

            return View(moviesList);
        }
    }
}
