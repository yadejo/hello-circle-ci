using System;
using Movies.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Domain.DataAccess {
    public interface IMoviesRepository {
        Task<List<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(Guid id);
        Task<Movie> SaveMovieAsync(Movie movie);
    }
}