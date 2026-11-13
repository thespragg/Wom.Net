using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Configuration;

internal static class JsonOptions
{
    private static readonly HashSet<Type> SnakeCaseTypes =
    [
        typeof(SkillsData),
        typeof(BossesData),
        typeof(ActivitiesData),
        typeof(ComputedData)
    ];

    internal static JsonSerializerOptions Default =>
        new()
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower) },
            TypeInfoResolver = new DefaultJsonTypeInfoResolver { Modifiers = { UseSnakeCasePropertyNames } }
        };

    private static void UseSnakeCasePropertyNames(JsonTypeInfo typeInfo)
    {
        if (!SnakeCaseTypes.Contains(typeInfo.Type))
            return;

        foreach (var property in typeInfo.Properties)
            property.Name = JsonNamingPolicy.SnakeCaseLower.ConvertName(property.Name);
    }
}