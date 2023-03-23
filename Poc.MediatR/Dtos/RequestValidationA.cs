using MediatR;

namespace Poc.MediatR.Dtos
{
    public class RequestValidationA : RequestBase, IRequest
    {
        public int Count { get; set; }
    }
}
