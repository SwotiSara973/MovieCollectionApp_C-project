namespace Movie_Collection_App.DataTransferObjects_DTOs_
{
    public class Role
    {
        public int Id { get; set; }

        // Initializing with string.Empty to prevent warnings
        public string RoleName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}