using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movies.Domain.Handlers;
using MediatR;

namespace Movies.Host.Controllers.Movies
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMediator _mediator;

        public MoviesController(ILogger<MoviesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<GetMoviesResponse>>> GetAsync()
        {
            return Ok(await _mediator.Send(new GetMoviesRequest()));
        }

        [HttpGet]
        [Route("{movieId}")]
        public async Task<ActionResult<GetMovieByIdResponse>> GetByIdAsync(Guid movieId)
        {
            var movie = await _mediator.Send(new GetMovieByIdRequest(movieId));

            if(movie == null) {
                return NotFound();
            }

            return Ok(movie);
        }
    }
}
