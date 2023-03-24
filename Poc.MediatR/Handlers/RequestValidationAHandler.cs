using MediatR;
using Poc.MediatR.Dtos;

namespace Poc.MediatR.Handlers
{
    public class RequestValidationAHandler : IRequestHandler<RequestValidationA, HandlersResponse>
    {
        public Task<HandlersResponse> Handle(RequestValidationA request, CancellationToken cancellationToken)
        {
            //Do all the validations for Request A


            return Task.FromResult(new HandlersResponse(true));
        }
    }

}
