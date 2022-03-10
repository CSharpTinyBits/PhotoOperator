using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace PhotoOperator.Controllers.Pluggins
{
    [Route("pluggins")]
    public class PlugginsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PlugginsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        public async Task<GetAll.Response> GetAll(GetAll.Request request, CancellationToken ct)
            => await _mediator.Send(request, ct);
    }
}
