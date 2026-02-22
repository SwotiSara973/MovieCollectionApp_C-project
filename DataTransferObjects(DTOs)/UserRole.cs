namespace Movie_Collection_App.DataTransferObjects_DTOs_
{
    public class UserRole
    {
        public int Id { get; set; }

        // These IDs link to the User and Role tables
        public int UserId { get; set; }
        public int RoleId { get; set; }

        // We add these strings so we can easily show the names on the Dashboard
        public string Username { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
    }
}