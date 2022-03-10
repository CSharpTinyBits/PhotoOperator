using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PhotoOperator.Controllers.Apply
{
    public class Handler : AsyncRequestHandler<Request>
    {
        protected override Task Handle(Request request, CancellationToken cancellationToken)
        {


            return Task.CompletedTask;
        }
    }
}
