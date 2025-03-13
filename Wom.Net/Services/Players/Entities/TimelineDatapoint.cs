using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents a timeline data point for a player's metric.
/// </summary>
[PublicAPI]
public sealed record TimelineDatapoint
{
    /// <summary>The player's value for the metric at a specific point in time.</summary>
    public double Value { get; init; }

    /// <summary>The player's rank for the metric at a specific point in time.</summary>
    public int Rank { get; init; }

    /// <summary>The date the data point was recorded.</summary>
    public DateTime Date { get; init; }
}
