using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents an activity leader in a group.
/// </summary>
[PublicAPI]
public sealed record ActivityLeader
{
    /// <summary>The activity's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The player's rank in this activity.</summary>
    public int Rank { get; init; }

    /// <summary>The player's score in this activity.</summary>
    public int Score { get; init; }

    /// <summary>The player who leads in this activity (can be null if no player leads).</summary>
    public Player? Player { get; init; }
}