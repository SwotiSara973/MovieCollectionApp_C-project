namespace Movie_Collection_App.DataTransferObjects_DTOs_
{
    public class UserMenu
    {
        public int Id { get; set; }

        // Links a specific User to a specific Menu item
        public int UserId { get; set; }
        public int MenuId { get; set; }

        // These help us display the information on the Dashboard easily
        public string MenuTitle { get; set; } = string.Empty;
        public bool IsVisible { get; set; } = true;
    }
}