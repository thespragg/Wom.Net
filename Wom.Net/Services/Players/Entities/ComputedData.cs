namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents computed metrics.
/// </summary>
public sealed record ComputedData
{
    /// <summary>Efficient Hours Played (EHP) data.</summary>
    public ComputedMetricData Ehp { get; init; }

    /// <summary>Efficient Hours Bossed (EHB) data.</summary>
    public ComputedMetricData Ehb { get; init; }
}
    
/// <summary>
/// Represents a computed metric's data.
/// </summary>
public sealed record ComputedMetricData
{
    /// <summary>The computed metric's name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The computed metric's rank.</summary>
    public int Rank { get; init; }

    /// <summary>The computed metric's value.</summary>
    public double Value { get; init; }
}