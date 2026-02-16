using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a competition history data point.
/// </summary>
[PublicAPI]
public sealed record CompetitionHistoryDatapoint
{
    /// <summary>The player's value for the competition metric, at a specific point in time.</summary>
    public double Value { get; init; }

    /// <summary>The date at which the datapoint was recorded.</summary>
    public DateTime Date { get; init; }
}