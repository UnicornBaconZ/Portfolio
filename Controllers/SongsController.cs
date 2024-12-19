using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Data.SQLite;

namespace Portfolio.Controllers
{
    public class SongsController : Controller
    {
        public IActionResult Index()
        {
            var songsList = new List<SongItem>();
            using (var connection = new SQLiteConnection("Data Source=Data/portfolio.db"))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT Title, Artist, SongFile, SongImage FROM songs", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        songsList.Add(new SongItem
                        {
                            Title = reader.GetString(0),
                            Artist = reader.GetString(1),
                            SongFile = reader.GetString(2),
                            SongImage = reader.GetString(3)
                        });
                    }
                }
            }

            return View(songsList);
        }
    }
}
