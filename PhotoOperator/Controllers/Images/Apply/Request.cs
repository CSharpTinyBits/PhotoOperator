using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PhotoOperator.Controllers.Apply
{
    public class Request : IRequest
    {
        [FromBody] public ImageApplyModel RequestBody { get; set; }
    }
}
