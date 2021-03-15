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
                new Movie("Twelve Angry Men", 8, "https://yadejomoviesapp.blob.core.windows.net/movieposters/041cc115-4871-4ef1-afe3-324a1527081e"),
                new Movie("Interstellar", 9, "https://yadejomoviesapp.blob.core.windows.net/movieposters/interstellar.jpg"),
                new Movie("A Rainy Day In New York", 7, "https://yadejomoviesapp.blob.core.windows.net/movieposters/rainy.jpg"),
                new Movie("La la land", 8, "https://yadejomoviesapp.blob.core.windows.net/movieposters/1a7e0b20-9cb5-4908-ae7c-f1431ec563c7.jpg"),
            };
        public Task<List<Movie>> GetAllMoviesAsync() {
            return Task.FromResult(_movies);
        }

        public Task<Movie> GetMovieByIdAsync(Guid id) {
            return Task.FromResult(_movies.FirstOrDefault(movie => movie.Id == id));
        }
    }
}
