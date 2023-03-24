using MediatR;

namespace Poc.MediatR.Dtos
{
    public class RequestValidationA : RequestBase, IRequest<HandlersResponse>
    {
        public int Count { get; set; }
    }
}
