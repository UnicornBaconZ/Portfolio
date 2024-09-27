using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Collections.Generic;

namespace Portfolio.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            var moviesList = new List<MediaItem>
        {
            new MediaItem { Title = "Spy x Family", ImageUrl = "/Assets/Series/spyxfamily.jpg", Rating = 9.2, Description = "A fantastic anime serie.", Genre = "Action/Comedy" },
            new MediaItem { Title = "Demon Slayer", ImageUrl = "/Assets/Series/demonslayer.jpg", Rating = 9.4, Description = "An anime full of action.", Genre = "Action"  }
        };

            return View(moviesList);
        }
    }
}
