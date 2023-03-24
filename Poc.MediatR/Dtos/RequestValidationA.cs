using MediatR;

namespace Poc.MediatR.Dtos
{
    public class RequestValidationA : RequestBase
    {
        public int Count { get; set; }
    }
}
