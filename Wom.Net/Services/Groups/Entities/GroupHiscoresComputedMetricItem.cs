using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group hiscores computed metric item.
/// </summary>
[PublicAPI]
public sealed record GroupHiscoresComputedMetricItem
{
    /// <summary>The type of this hiscores item ('computed').</summary>
    public string Type { get; init; } = "computed";

    /// <summary>The player's rank in a specific computed metric.</summary>
    public int Rank { get; init; }

    /// <summary>The player's value in a specific computed metric.</summary>
    public int Value { get; init; }
}
