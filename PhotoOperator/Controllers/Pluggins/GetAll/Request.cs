using MediatR;
using System;

namespace PhotoOperator.Controllers.Pluggins.GetAll
{
    public class Request : IRequest<Response>
    {
        public Guid UserId { get; set; }
    }
}
