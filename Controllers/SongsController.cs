using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class SongsController : Controller
    {
        public IActionResult Index()
        {
            var songsList = new List<SongItem>
        {
            new SongItem { Title = "Led to lead", Artist = "Fizzle, Alex White", SongFile="/Assets/Songs/LedToLead.mp3", SongImage="/Assets/Songs/LedToLead.jpg" },
            new SongItem { Title = "Led to lead", Artist = "Fizzle, Alex White", SongFile="/Assets/Songs/LedToLead.mp3", SongImage="/Assets/Songs/LedToLead.jpg" },
            new SongItem { Title = "Led to lead", Artist = "Fizzle, Alex White", SongFile="/Assets/Songs/LedToLead.mp3", SongImage="/Assets/Songs/LedToLead.jpg" },
            new SongItem { Title = "Led to lead", Artist = "Fizzle, Alex White", SongFile="/Assets/Songs/LedToLead.mp3", SongImage="/Assets/Songs/LedToLead.jpg" },
            new SongItem { Title = "Led to lead", Artist = "Fizzle, Alex White", SongFile="/Assets/Songs/LedToLead.mp3", SongImage="/Assets/Songs/LedToLead.jpg" },
            new SongItem { Title = "Flowers need rain", Artist = "Preston Pablo", SongFile="/Assets/Songs/FlowersNeedRain.mp3", SongImage="/Assets/Songs/FlowersNeedRain.jpg"  }
        };

            return View(songsList);
        }
    }
}
