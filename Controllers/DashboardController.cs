using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Movie_Collection_App.Data;

namespace Movie_Collection_App.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context) { _context = context; }

        public IActionResult Index()
        {
            string? user = HttpContext.Session.GetString("UserName");

            // Authorization: Enable "Add Movie" only for Admin
            if (user == "admin")
            {
                ViewBag.UserRole = "Admin";
                ViewBag.CanAddMovie = true;
            }
            else
            {
                ViewBag.UserRole = "Guest";
                ViewBag.CanAddMovie = false;
            }

            ViewBag.TotalMovies = _context.Movies.Count();
            return View(_context.Movies.ToList());
        }
    }
}