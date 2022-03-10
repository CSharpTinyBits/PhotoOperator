using MediatR;
using PhotoOperator.Domain.Images;
using System.Threading;
using System.Threading.Tasks;

namespace PhotoOperator.Controllers.Apply
{
    public class Handler : AsyncRequestHandler<Request>
    {
        protected override Task Handle(Request request, CancellationToken cancellationToken)
        {
            var image = GetImageByPath(request.RequestBody.ImagePath);

            foreach (var pluggin in request.RequestBody.AppliedPluggins)
            {
                pluggin.OnApply(image);
            }

            return Task.CompletedTask;
        }

        private Image GetImageByPath(string path)
        {
            return new Image();
        }
    }
}
