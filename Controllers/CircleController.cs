using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hello_circle_ci.Controllers
{
    [ApiController]
    [Route("")]
    public class CircleController : ControllerBase
    {
        private readonly ILogger<CircleController> _logger;

        public CircleController(ILogger<CircleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return @"
                                        
██╗░░██╗███████╗██╗░░░░░██╗░░░░░░█████╗░  ░█████╗░██╗██████╗░░█████╗░██╗░░░░░███████╗  ░█████╗░██╗
██║░░██║██╔════╝██║░░░░░██║░░░░░██╔══██╗  ██╔══██╗██║██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██║
███████║█████╗░░██║░░░░░██║░░░░░██║░░██║  ██║░░╚═╝██║██████╔╝██║░░╚═╝██║░░░░░█████╗░░  ██║░░╚═╝██║
██╔══██║██╔══╝░░██║░░░░░██║░░░░░██║░░██║  ██║░░██╗██║██╔══██╗██║░░██╗██║░░░░░██╔══╝░░  ██║░░██╗██║
██║░░██║███████╗███████╗███████╗╚█████╔╝  ╚█████╔╝██║██║░░██║╚█████╔╝███████╗███████╗  ╚█████╔╝██║
╚═╝░░╚═╝╚══════╝╚══════╝╚══════╝░╚════╝░  ░╚════╝░╚═╝╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ░╚════╝░╚═╝
            ";
        }
    }
}
