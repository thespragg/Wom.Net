using JetBrains.Annotations;
using Wom.Net.Services.Deltas.Entities;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group bulk gains entry.
/// </summary>
[PublicAPI]
public sealed record GroupBulkGainsEntry
{
    /// <summary>The delta's parent player object.</summary>
    public Player Player { get; init; } = null!;

    /// <summary>The delta's progress for every metric.</summary>
    public IEnumerable<MetricDelta> Data { get; init; } = null!;

    /// <summary>The starting date of the delta's timespan.</summary>
    public DateTime StartDate { get; init; }

    /// <summary>The ending date of the delta's timespan.</summary>
    public DateTime EndDate { get; init; }
}