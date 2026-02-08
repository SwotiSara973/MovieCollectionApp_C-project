namespace Movie_Collection_App.Models.ViewModels
{
    // This class is only for the "Add Movie" form. 
    // It doesn't have an ID because the computer makes that later!
    public class AddMovieViewModel
    {
        // This is for the Title the user types in.
        public string Title { get; set; } = string.Empty;

        // This is for the Genre the user types in.
        public string Genre { get; set; } = string.Empty;

        // This is for the Year the user types in.
        public int ReleaseYear { get; set; }

        // This is for the Director the user types in.
        public string Director { get; set; } = string.Empty;

        // This is for the Rating the user types in.
        public double Rating { get; set; }
    }
}