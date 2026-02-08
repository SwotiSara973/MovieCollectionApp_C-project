namespace Movie_Collection_App.Models
{
    // This is the Movie class. It's like a template for every movie in my app.
    public class Movie
    {
        // This is a special ID number for the database to find each movie.
        public Guid Id { get; set; }

        // This stores the name of the movie.
        public string Title { get; set; } = string.Empty;

        // This stores the category, like Action or Comedy.
        public string Genre { get; set; } = string.Empty;

        // This stores the year the movie came out.
        public int ReleaseYear { get; set; }

        // This stores the name of the person who made the movie.
        public string Director { get; set; } = string.Empty;

        // This stores the score of the movie, like 8.5.
        public double Rating { get; set; }
    }
}