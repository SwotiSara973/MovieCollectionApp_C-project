

using Microsoft.EntityFrameworkCore;
using Movie_Collection_App.Models; // This helps the bridge find our Movie class

namespace Movie_Collection_App.Data
{
    // This class is the "Bridge" between my code and the SQL database.
    // It inherits from DbContext, which is a tool from Entity Framework.
    public class ApplicationDbContext : DbContext
    {
        // This constructor is like a setup instruction for the bridge.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // This line tells the computer to create a table called "Movies" 
        // based on our Movie model.
        public DbSet<Movie> Movies { get; set; }
    }
}