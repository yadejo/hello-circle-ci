using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Movies.Domain.DataAccess;
using MediatR;
using Movies.Domain.Models;

namespace Movies.Domain.Handlers {
    public class CreateMovieHandler : IRequestHandler<CreateMovieRequest, CreateMovieResponse> {

        private readonly IMoviesRepository _moviesRepository;
        public CreateMovieHandler(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }
        
        public async Task<CreateMovieResponse> Handle(CreateMovieRequest request, CancellationToken cancellationToken) {
            var movieToSave = new Movie(request.Title, request.Rating, request.PosterUri);

            var savedMovie = await _moviesRepository.SaveMovieAsync(movieToSave);

            return new CreateMovieResponse(savedMovie.Id, savedMovie.Title, savedMovie.Rating, savedMovie.PosterUri);
        }
    }

    public class CreateMovieResponse {
        public CreateMovieResponse(Guid id,string title, int rating, string posterUri)
        {
            Id = id;
            Title = title;
            Rating = rating;
            PosterUri = posterUri;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string PosterUri { get; set; }
    }

    public class CreateMovieRequest : IRequest<CreateMovieResponse> {

        public string Title { get; set; }
        public int Rating { get; set; }
        public string PosterUri { get; set; }
        public CreateMovieRequest(string title, int rating, string posterUri)
        {
            Title = title;
            Rating = rating;
            PosterUri = posterUri;
        }
    }
}