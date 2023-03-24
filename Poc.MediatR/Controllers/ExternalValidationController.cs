using MediatR;
using Microsoft.AspNetCore.Mvc;
using Poc.MediatR.Dtos;

namespace Poc.MediatR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExternalValidationController : ControllerBase
    {

        private readonly ILogger<ExternalValidationController> _logger;
        private IMediator mediator;

        public ExternalValidationController(ILogger<ExternalValidationController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpPost()]
        public async Task<IActionResult> Post([FromBody] RequestBase request)
        {
            var response = await mediator.Send(request);

            return Ok(response);
        }
    }
}