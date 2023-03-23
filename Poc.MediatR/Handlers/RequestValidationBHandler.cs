using MediatR;
using Poc.MediatR.Dtos;

namespace Poc.MediatR.Handlers
{
    public class RequestValidationBHandler : IRequestHandler<RequestValidationB>
    {
        public Task Handle(RequestValidationB request, CancellationToken cancellationToken)
        {
            //Do validation for request B

            return Task.CompletedTask;
        }
    }
}
