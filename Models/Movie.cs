using System.ComponentModel.DataAnnotations;

namespace movieAPP.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }
          

          [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string? Genres { get; set; }

         [Display(Name = "Released Year")]
        public string? YearReleased { get; set; }
    }
}
