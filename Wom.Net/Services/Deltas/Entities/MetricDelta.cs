using JetBrains.Annotations;

namespace Wom.Net.Services.Deltas.Entities;

/// <summary>
/// Represents a metric delta.
/// </summary>
[PublicAPI]
public sealed record MetricDelta
{
    /// <summary>The delta's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>A player's start value for some time period.</summary>
    public double Start { get; init; }

    /// <summary>A player's end value for some time period.</summary>
    public double End { get; init; }

    /// <summary>A player's gained value for some time period.</summary>
    public double Gained { get; init; }
}