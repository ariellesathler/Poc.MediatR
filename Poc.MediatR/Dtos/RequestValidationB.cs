using MediatR;

namespace Poc.MediatR.Dtos
{
    public class RequestValidationB : RequestBase
    {
        public string Name { get; set; } = string.Empty;
    }
}
