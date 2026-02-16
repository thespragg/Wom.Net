using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a delta group leaderboard entry.
/// </summary>
[PublicAPI]
public sealed record DeltaGroupLeaderboardEntry
{
    /// <summary>The delta's parent player object.</summary>
    public Player Player { get; init; } = null!;

    /// <summary>The delta's progress.</summary>
    public GroupDeltaProgress Data { get; init; } = null!;

    /// <summary>The starting date of the delta's timespan.</summary>
    public DateTime StartDate { get; init; }

    /// <summary>The ending date of the delta's timespan.</summary>
    public DateTime EndDate { get; init; }
}