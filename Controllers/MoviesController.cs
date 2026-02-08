using Microsoft.AspNetCore.Mvc;
using Movie_Collection_App.Data;
using Movie_Collection_App.Models;
using Movie_Collection_App.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Movie_Collection_App.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(AddMovieViewModel viewModel)
        {
            var movie = new Movie
            {
                Title = viewModel.Title,
                Genre = viewModel.Genre,
                ReleaseYear = viewModel.ReleaseYear,
                Director = viewModel.Director,
                Rating = viewModel.Rating
            };
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var movies = await _context.Movies.ToListAsync();
            return View(movies);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }
    }
}