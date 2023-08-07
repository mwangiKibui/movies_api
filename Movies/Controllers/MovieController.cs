using System;
using Microsoft.AspNetCore.Mvc;
using Movies.Services.Movies;

namespace Movies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
	{

        private readonly IMovieService _movieService;

        public MovieController(IMovieService movie)
        {
            _movieService = movie;
        }

        [HttpGet(Name ="Getting movies")]
		public async Task<ActionResult<CustomResponse<List<Movie>>>> getMovies()
		{
            return Ok( await _movieService.getMovies()); 
		}

        [HttpGet("{id}",Name = "Getting a single movies")]
        public async Task<ActionResult<CustomResponse<Movie>>> getSingleMovie(int id)
        {
            return Ok(await _movieService.getSingleMovie(id));
        }

        [HttpPost(Name ="Adding a movie")]

        public async Task<ActionResult<CustomResponse<List<Movie>>>> addMovie(Movie movie)
        {
            return Ok(await _movieService.addMovie(movie));
        }

        [HttpPut(Name = "Updating a movie")]

        public async Task<ActionResult<CustomResponse<List<Movie>>>> updateMovie(Movie movie)
        {
            return Ok(await _movieService.updateMovie(movie));
        }

        [HttpDelete("{id}",Name ="Deleting a Movie")]
        public async Task<ActionResult<CustomResponse<List<Movie>>>> deleteMovie(int id)
        {
            return Ok(await _movieService.deleteMovie(id));
        }
    }
}

