using System;
using Movies.Models;

namespace Movies.Services.Movies
{
	public class MovieService : IMovieService
	{
        private readonly DataContext _dbContext;

        public MovieService(DataContext dbContext)
		{
           _dbContext = dbContext;
        }

        public async Task<CustomResponse<List<Movie>>> addMovie(Movie movie)
        {
            try
            {
                _dbContext.Add(movie);
                await _dbContext.SaveChangesAsync();

                var movies = await _dbContext.Movies.ToListAsync();

                var response = new CustomResponse<List<Movie>>();
                response.Data = movies;
                response.Message = "Movies fetched successfully";

                return response;
            }
            catch(Exception error)
            {
                var response = new CustomResponse<List<Movie>>();
                response.Data = null;
                response.Success = false;
                response.Message = error.Message;

                return response;
            }
            
        }

        public async Task<CustomResponse<List<Movie>>> deleteMovie(int id)
        {
            try
            {
                 _dbContext.Movies.Remove(new Movie { Id = id});
                await _dbContext.SaveChangesAsync();

                var movies = await _dbContext.Movies.ToListAsync();
                var response = new CustomResponse<List<Movie>>();
                response.Data = movies;
                response.Message = "Movie Deleted Successfully";

                return response;
            }
            catch(Exception error)
            {
                var response = new CustomResponse<List<Movie>>();
                response.Data = null;
                response.Success = false;
                response.Message = error.Message;
                return response;
            }
            
        }

        public async Task<CustomResponse<List<Movie>>> getMovies()
        {
            try
            {
                var movies = await _dbContext.Movies.ToListAsync();
                var response = new CustomResponse<List<Movie>>();
                response.Data = movies;
                response.Message = "Movies Fetched Successfully";
                return response;
            }catch(Exception error)
            {
                var response = new CustomResponse<List<Movie>>();
                response.Data = null;
                response.Success = false;
                response.Message = error.Message;
                return response;
            }
            
        }

        public async Task<CustomResponse<Movie>> getSingleMovie(int id)
        {
            try
            {
                var movie = await _dbContext.Movies.FirstOrDefaultAsync(c => c.Id == id);
                var response = new CustomResponse<Movie>();
                response.Data = movie;
                response.Message = "Movie Fetched Successfully";
                return response;
            }
            catch (Exception error)
            {
                var response = new CustomResponse<Movie>();
                response.Data = null;
                response.Success = false;
                response.Message = error.Message;
                return response;
            }
            
        }

        public async Task<CustomResponse<List<Movie>>> updateMovie(Movie movie)
        {
            try
            {
                _dbContext.Update(movie);
                await _dbContext.SaveChangesAsync();
                var movies = await _dbContext.Movies.ToListAsync();
                var response = new CustomResponse<List<Movie>>();
                response.Data = movies;
                response.Message = "Movie Updated Successfully";
                return response;
            }
            catch(Exception error)
            {
                var response = new CustomResponse<List<Movie>>();
                response.Data = null;
                response.Success = false;
                response.Message = error.Message;
                return response;
            }
            
        }
    }
}

