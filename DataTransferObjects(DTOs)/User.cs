using System.ComponentModel.DataAnnotations;

namespace Movie_Collection_App.DataTransferObjects_DTOs_
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }

        // Our unique logic to keep it different from the professor
        public bool IsActive { get; set; }
        public string UserStatus => IsActive ? "Active" : "Locked";
    }
}