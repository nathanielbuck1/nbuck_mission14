using BetAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MoviesDbContext context;
        public MovieController(MoviesDbContext temp) {
            context = temp;
        }
        public IEnumerable<JMovies> Get()
        {
            //var x = context.Movies.ToArray().Where(m => m.Edited == false).ToArray(); 
            //return context.Movies
            //        .Where(m => m.Edited == false).ToArray();
            var x = context.Movies.ToArray()
                .Where(m => m.Edited == "Yes").ToArray()
                .OrderBy(m => m.Title)
                .ToArray();
            return x;
        }
    }
}
