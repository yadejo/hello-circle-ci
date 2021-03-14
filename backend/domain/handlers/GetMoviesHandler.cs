using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Movies.Domain.DataAccess;
using MediatR;

namespace Movies.Domain.Handlers
{
    public class GetMoviesHandler : IRequestHandler<GetMoviesRequest, List<GetMoviesResponse>>
    {

        private readonly IGetMoviesRepository _getMoviesRepository;
        public GetMoviesHandler(IGetMoviesRepository getMoviesRepository)
        {
            _getMoviesRepository = getMoviesRepository;
        }

        public async Task<List<GetMoviesResponse>> Handle(GetMoviesRequest request, CancellationToken cancellationToken)
        {
            var movies = await _getMoviesRepository.GetAllMoviesAsync();

            return movies.Select(movie => new GetMoviesResponse
            {
                Id = movie.Id,
                Title = movie.Title,
                Rating = movie.Rating
            }).ToList();
        }
    }

    public class GetMoviesResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
    }

    public class GetMoviesRequest : IRequest<List<GetMoviesResponse>> {}
}