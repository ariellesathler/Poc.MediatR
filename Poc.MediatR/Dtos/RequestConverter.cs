using System.Text.Json;
using System.Text.Json.Serialization;

namespace Poc.MediatR.Dtos
{
    public class RequestConverter : JsonConverter<RequestBase>
    {
        public override RequestBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
            if (!jsonElement.TryGetProperty("Type", out var property) && !jsonElement.TryGetProperty("type", out property))
            {
                throw new JsonException("Required property 'Type' is missing.");
            }

            return GetIdentifierValue(property) switch
            {
                RequestsType.TypeA => (RequestValidationA)JsonSerializer.Deserialize(jsonElement.GetRawText(), typeof(RequestValidationA), options)!,
                RequestsType.TypeB => (RequestValidationB)JsonSerializer.Deserialize(jsonElement.GetRawText(), typeof(RequestValidationB), options)!,
                _ => throw new JsonException("Unable to convert request type")
            };

        }

        public override void Write(Utf8JsonWriter writer, RequestBase value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value!.GetType(), options);
        }

        private RequestsType GetIdentifierValue(JsonElement property)
        {
            return property.ValueKind switch
            {
                JsonValueKind.String => Enum.TryParse<RequestsType>(property.GetString(), out var stringKind)
                    ? stringKind
                    : throw new JsonException($"Cant convert value {property.GetRawText()} to RequestsType"),
                JsonValueKind.Number => Enum.TryParse<RequestsType>(property.GetInt16().ToString(), out var stringKind)
                    ? stringKind
                    : throw new JsonException($"Cant convert value {property.GetRawText()} to RequestsType"),
                _ => throw new JsonException($"Cant convert value {property.GetRawText()} to RequestsType"),
            };
        }
    }
}
