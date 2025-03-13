using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a computed metric leader in a group.
/// </summary>
[PublicAPI]
public sealed record ComputedMetricLeader
{
    /// <summary>The computed metric's name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The player's rank in this computed metric.</summary>
    public int Rank { get; init; }

    /// <summary>The player's value in this computed metric.</summary>
    public int Value { get; init; }

    /// <summary>The player who leads in this computed metric.</summary>
    public Player Player { get; init; } = null!;
}