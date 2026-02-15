using Microsoft.EntityFrameworkCore;

namespace Movie_Collection_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 1. Movie is in the Models folder
        public DbSet<Movie_Collection_App.Models.Movie> Movies { get; set; }

        // 2. Security Tables are in the DTOs folder
        // This tells the computer exactly where to find the classes to stop the red lines
        public DbSet<Movie_Collection_App.DataTransferObjects_DTOs_.User> Users { get; set; }
        public DbSet<Movie_Collection_App.DataTransferObjects_DTOs_.Role> Roles { get; set; }
        public DbSet<Movie_Collection_App.DataTransferObjects_DTOs_.UserRole> UserRoles { get; set; }

        // 3. Navigation Tables are also in the DTOs folder
        public DbSet<Movie_Collection_App.DataTransferObjects_DTOs_.Menu> Menus { get; set; }
        public DbSet<Movie_Collection_App.DataTransferObjects_DTOs_.UserMenu> UserMenus { get; set; }
    }
}