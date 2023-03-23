using System.Data.Common;
using System.Text.Json.Serialization;

namespace Poc.MediatR.Dtos
{
    [JsonConverter(typeof(RequestConverter))]
    public abstract class RequestBase
    {
        public Guid Id { get; set; }
        public RequestsType Type { get; set; }
    }
}
