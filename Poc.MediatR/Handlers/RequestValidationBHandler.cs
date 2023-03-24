using MediatR;
using Poc.MediatR.Dtos;

namespace Poc.MediatR.Handlers
{
    public class RequestValidationBHandler : IRequestHandler<RequestValidationB, HandlersResponse>
    {
        public Task<HandlersResponse> Handle(RequestValidationB request, CancellationToken cancellationToken)
        {
            //Do all the validations for RequestB


            return Task.FromResult(new HandlersResponse(new List<string> { "error 1", "error 2"}));
        }
    }
}
