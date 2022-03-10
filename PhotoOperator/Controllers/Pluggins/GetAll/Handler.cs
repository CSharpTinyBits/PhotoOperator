using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PhotoOperator.Controllers.Pluggins.GetAll
{
    public class Handler : IRequestHandler<Request, Response>
    {
        public Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
