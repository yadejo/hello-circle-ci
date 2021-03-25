using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movies.Domain.Handlers;
using Movies.Domain.Models;
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

        [HttpGet("")]

        public async Task<ActionResult<List<GetMoviesResponse>>> GetAll()
        {
            return Ok(await _mediator.Send(new GetMoviesRequest()));
        }

        [HttpGet("{movieId}")]
        public async Task<ActionResult<GetMovieByIdResponse>> GetById(Guid movieId)
        {
            var movie = await _mediator.Send(new GetMovieByIdRequest(movieId));

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost("")]
        public async Task<ActionResult<GetMovieByIdResponse>> CreateMovie([FromBody] CreateMovieRequest createMovieRequest)
        {
            try {
                var response = await _mediator.Send(createMovieRequest);
                return Created($"api/movies/{response.Id}", response);
            } catch(InvalidRatingException) {
                return BadRequest();
            }
        }
    }
}
