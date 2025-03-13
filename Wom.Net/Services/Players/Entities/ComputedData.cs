using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents computed metrics.
/// </summary>
[PublicAPI]
public sealed record ComputedData
{
    /// <summary>Efficient Hours Played (EHP) data.</summary>
    public ComputedMetricData Ehp { get; init; } = null!;

    /// <summary>Efficient Hours Bossed (EHB) data.</summary>
    public ComputedMetricData Ehb { get; init; } = null!;
}
    
/// <summary>
/// Represents a computed metric's data.
/// </summary>
[PublicAPI]
public sealed record ComputedMetricData
{
    /// <summary>The computed metric's name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The computed metric's rank.</summary>
    public int Rank { get; init; }

    /// <summary>The computed metric's value.</summary>
    public double Value { get; init; }
}