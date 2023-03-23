using MediatR;

namespace Poc.MediatR.Dtos
{
    public class RequestValidationB : RequestBase, IRequest
    {
        public string Name { get; set; } = string.Empty;
    }
}
