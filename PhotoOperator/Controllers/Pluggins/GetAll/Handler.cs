using MediatR;
using Microsoft.Extensions.Options;
using PhotoOperator.Domain.Pluggins;
using PhotoOperator.Settings;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PhotoOperator.Controllers.Pluggins.GetAll
{
    public class Handler : IRequestHandler<Request, Response>
    {
        private readonly EnabledPluggins _enabledPluggins;

        public Handler(IOptions<EnabledPluggins> enabledPluggins)
        {
            _enabledPluggins = enabledPluggins.Value;
        }

        public Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            // Just to satisfy compiler
            return Task.Run(() => new Response { AllowedPluggins = _enabledPluggins.Pluggins.Select(MapToViewModel).ToArray() });
        }

        private static PlugginBase MapToViewModel(PlugginType plugginType)
        {
            switch (plugginType)
            {
                case PlugginType.Input:
                    return new InputPluggin("Size", "");
                case PlugginType.Slider:
                    return new SliderPluggin(0, "Radius");
                case PlugginType.CheckBox:
                    // Allowed Pluggins should be more complex in order to use title more effective
                    return new CheckBoxPluggin(false, "Effect");
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}