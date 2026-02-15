namespace Movie_Collection_App.DataTransferObjects_DTOs_
{
    public class Menu
    {
        public int Id { get; set; }

        // The text that appears on the button (e.g., "Add New Movie")
        public string Title { get; set; } = string.Empty;

        // The URL or path where the link goes
        public string Url { get; set; } = string.Empty;

        // UNIQUE ADDITION: This allows you to add icons (like a home or movie icon) 
        // to your dashboard, which makes it look better than the professor's sample.
        public string Icon { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}