using System.Text.Json;
using System.Text.Json.Serialization;

namespace Wom.Net.Configuration;

internal static class JsonOptions
{
    internal static JsonSerializerOptions Default =>
        new()
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower) }
        };
}