using System.ComponentModel.DataAnnotations;

namespace Movie_Collection_App.Models
{
    // This is the Movie class. It's like a template for every movie in my app.
    public class Movie
    {
        // This is a special ID number for the database to find each movie.
        [Key]
        public Guid Id { get; set; }

        // This stores the name of the movie. 
        // [Required] ensures the API returns an error if the Title is missing.
        [Required(ErrorMessage = "Movie Title is required.")]
        public string Title { get; set; } = string.Empty;

        // This stores the category, like Action or Comedy.
        [Required(ErrorMessage = "Genre is required.")]
        public string Genre { get; set; } = string.Empty;

        // This stores the year the movie came out.
        // [Range] ensures the year is realistic for a movie.
        [Range(1888, 2026, ErrorMessage = "Please enter a valid release year.")]
        public int ReleaseYear { get; set; }

        // This stores the name of the person who made the movie.
        public string Director { get; set; } = string.Empty;

        // This stores the score of the movie.
        // [Range] limits the rating to a standard 1-10 scale.
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public double Rating { get; set; }
    }
}