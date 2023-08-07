using System;
namespace Movies.Services.Movies
{
	public interface IMovieService
	{
        Task<CustomResponse<List<Movie>>> getMovies();
		Task<CustomResponse<Movie>> getSingleMovie(int id);
		Task<CustomResponse<List<Movie>>> addMovie(Movie movie);
		Task<CustomResponse<List<Movie>>> updateMovie(Movie movie);
		Task<CustomResponse<List<Movie>>> deleteMovie(int id);
	}
}

