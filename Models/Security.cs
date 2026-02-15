namespace Movie_Collection_App.Models
{
    // Ensure this class exists
    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }

    // Ensure this class exists
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Controller { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
    }
}