using System;
using MovApi.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovApi.Domain.DataAccess {
    public interface IGetMoviesRepository {
        Task<List<Movie>> GetAllMoviesAsync();
    }
}