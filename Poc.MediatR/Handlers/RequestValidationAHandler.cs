using MediatR;
using Poc.MediatR.Dtos;

namespace Poc.MediatR.Handlers
{
    public class RequestValidationAHandler : IRequestHandler<RequestValidationA>
    {
        public Task Handle(RequestValidationA request, CancellationToken cancellationToken)
        {
            //Do validation for request A

            return Task.CompletedTask;
        }
    }
}
