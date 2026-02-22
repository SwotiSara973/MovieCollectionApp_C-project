using Microsoft.AspNetCore.Mvc;
using Movie_Collection_App.Models; // Ensure this matches your namespace
using System.Collections.Generic;
using System.Linq;

namespace Movie_Collection_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // This ensures the data is returned in JSON format
    public class MovieApiController : ControllerBase
    {
        // For now, we use a static list to simulate a database for testing
        private static List<Movie> _movies = new List<Movie>();

        // 1. Get Movies: Retrieve all movies
        // GET: /api/MovieApi
        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(_movies);
        }

        // 2. Get Movie by ID: Retrieve a specific movie
        // GET: /api/MovieApi/{id}
        [HttpGet("{id}")]
        public IActionResult GetMovieById(Guid id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound("Movie not found.");
            return Ok(movie);
        }

        // 3. Add Movie: Create a new movie
        // POST: /api/MovieApi
        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState); // Validation check

            movie.Id = Guid.NewGuid(); // Give it a new ID
            _movies.Add(movie);
            return Ok(new { message = "Movie added successfully!", movie });
        }

        // 4. Update Movie: Edit an existing movie
        // PUT: /api/MovieApi/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(Guid id, [FromBody] Movie updatedMovie)
        {
            var existingMovie = _movies.FirstOrDefault(m => m.Id == id);
            if (existingMovie == null) return NotFound();

            existingMovie.Title = updatedMovie.Title;
            existingMovie.Genre = updatedMovie.Genre;
            existingMovie.ReleaseYear = updatedMovie.ReleaseYear;
            existingMovie.Rating = updatedMovie.Rating;

            return Ok("Movie updated successfully.");
        }

        // 5. Delete Movie: Remove a movie
        // DELETE: /api/MovieApi/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(Guid id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();

            _movies.Remove(movie);
            return Ok("Movie deleted successfully.");
        }
    }
}