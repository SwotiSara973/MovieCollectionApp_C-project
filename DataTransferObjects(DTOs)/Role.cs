<<<<<<< HEAD
﻿namespace Movie_Collection_App.DataTransferObjects_DTOs_
=======
namespace Movie_Collection_App.DataTransferObjects_DTOs_
>>>>>>> 1e36c2d991df0589f305fd9dd6535b60414cd984
{
    public class Role
    {
        public int Id { get; set; }

        // Initializing with string.Empty to prevent warnings
        public string RoleName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}