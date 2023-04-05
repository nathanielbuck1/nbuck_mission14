using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace BetAPI.Data
{
    public class JMovies
    {
        [Key]
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }  
        public string? Edited { get; set; }
    }
}
