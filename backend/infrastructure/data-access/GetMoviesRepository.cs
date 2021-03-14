using System;
using Movies.Domain.Models;
using Movies.Domain.DataAccess;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Movies.Infrastructure.DataAccess
{
    public class InMemoryGetMoviesRepository : IGetMoviesRepository
    {
        private static readonly List<Movie> _movies =  new List<Movie> {
                new Movie("Twelve Angry Men", 8),
                new Movie("Interstellar", 9),
                new Movie("A Rainy Day In New York", 7),
                new Movie("La la land", 8),
            };
        public Task<List<Movie>> GetAllMoviesAsync() {
            return Task.FromResult(_movies);
        }

        public Task<Movie> GetMovieByIdAsync(Guid id) {
            return Task.FromResult(_movies.FirstOrDefault(movie => movie.Id == id));
        }
    }
}
