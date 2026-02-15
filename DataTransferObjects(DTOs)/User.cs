<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> 1e36c2d991df0589f305fd9dd6535b60414cd984

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