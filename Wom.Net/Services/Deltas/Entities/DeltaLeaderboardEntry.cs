using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Deltas.Entities;

/// <summary>
/// Represents a delta leaderboard entry, showing a player's progress over a specific time period.
/// </summary>
[PublicAPI]
public sealed record DeltaLeaderboardEntry
{
    /// <summary>The delta's parent player ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The delta's gained value.</summary>
    public long Gained { get; init; }

    /// <summary>The starting date of the delta's timespan.</summary>
    public DateTime StartDate { get; init; }

    /// <summary>The ending date of the delta's timespan.</summary>
    public DateTime EndDate { get; init; }

    /// <summary>The delta's parent player object.</summary>
    public Player Player { get; init; } = null!;
}