using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Data.SQLite;

namespace Portfolio.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var moviesList = new List<MediaItem>();

            using (var connection = new SQLiteConnection("Data Source=Data/portfolio.db"))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT Title, ImageUrl, Rating, Description, Genre FROM Movies ORDER BY Rating DESC", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        moviesList.Add(new MediaItem
                        {
                            Title = reader.GetString(0),
                            ImageUrl = reader.GetString(1),
                            Rating = reader.GetDecimal(2),
                            Description = reader.GetString(3),
                            Genre = reader.GetString(4)
                        });
                    }
                }
            }

            return View(moviesList);
        }
    }
}
