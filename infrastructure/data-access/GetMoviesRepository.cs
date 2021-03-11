using System;
using MovApi.Domain.Models;
using MovApi.Domain.DataAccess;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MovApi.Infrastructure.DataAccess
{
    public class InMemoryGetMoviesRepository : IGetMoviesRepository
    {
        public Task<List<Movie>> GetAllMoviesAsync() {
            return Task.FromResult(new List<Movie> {
                new Movie("Twelve Angry Men", 8),
                new Movie("Interstellar", 9),
                new Movie("A Rainy Day In New York", 7),
                new Movie("La la land", 8),
            });
        }
    }
}
