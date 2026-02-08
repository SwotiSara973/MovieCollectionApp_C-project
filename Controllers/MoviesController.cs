using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movie_Collection_App.Data;
using Movie_Collection_App.Models;

namespace Movie_Collection_App.Controllers
{
    public class MoviesController : Controller
    {
        // This connects our controller to the database
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        // This shows the main list of all movies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        // GET: Movies/Details/5
        // This looks up one specific movie to show all its info
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        // This just opens the blank "Add Movie" page
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // This takes the info you typed and saves it as a new movie
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Genre,ReleaseYear,Director,Rating")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = Guid.NewGuid(); // Gives the new movie a unique ID number
                _context.Add(movie); // Adds it to the list
                await _context.SaveChangesAsync(); // Saves it to the database
                return RedirectToAction(nameof(Index)); // Goes back to the home list
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        // This opens the edit page for a specific movie
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // This takes the updated info and saves the changes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Genre,ReleaseYear,Director,Rating")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie); // Updates the movie with new info
                    await _context.SaveChangesAsync(); // Saves the update
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        // This opens a page to ask if you are sure you want to delete
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        // This actually removes the movie from the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie); // Deletes the movie
            }

            await _context.SaveChangesAsync(); // Saves the database after deletion
            return RedirectToAction(nameof(Index));
        }

        // This is a quick check to see if a movie exists in our database
        private bool MovieExists(Guid id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}