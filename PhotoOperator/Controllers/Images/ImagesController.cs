using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace PhotoOperator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task Apply(Apply.Request request, CancellationToken ct)
            => await _mediator.Send(request, ct);
    }
}
