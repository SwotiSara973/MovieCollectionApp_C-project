<<<<<<< HEAD
﻿namespace Movie_Collection_App.DataTransferObjects_DTOs_
=======
namespace Movie_Collection_App.DataTransferObjects_DTOs_
>>>>>>> 1e36c2d991df0589f305fd9dd6535b60414cd984
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