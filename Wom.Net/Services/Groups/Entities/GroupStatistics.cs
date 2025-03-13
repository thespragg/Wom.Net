using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents group statistics.
/// </summary>
[PublicAPI]
public sealed record GroupStatistics
{
    /// <summary>The total amount of members with 126 combat level (max combat).</summary>
    public int MaxedCombatCount { get; init; }

    /// <summary>The total amount of members with 2277 total level (maxed).</summary>
    public int MaxedTotalCount { get; init; }

    /// <summary>The total amount of 200m exp skills between all members.</summary>
    public int Maxed200MsCount { get; init; }

    /// <summary>The average stats of all group members.</summary>
    public Snapshot AverageStats { get; init; } = null!;

    /// <summary>The best player in each metric out of all group members.</summary>
    public MetricLeaders MetricLeaders { get; init; } = null!;
}