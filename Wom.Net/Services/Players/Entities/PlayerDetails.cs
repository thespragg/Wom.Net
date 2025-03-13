using JetBrains.Annotations;
using Wom.Net.Services.Players.Enums;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents detailed information about a player, extending the base <see cref="Player"/> record.
/// </summary>
[PublicAPI]
public record PlayerDetails : Player
{
    /// <summary>The player's combat level.</summary>
    public int CombatLevel { get; init; }

    /// <summary>The player's archive information.</summary>
    public PlayerArchive? Archive { get; init; }

    /// <summary>The player's latest snapshot.</summary>
    public Snapshot? LatestSnapshot { get; init; }

    /// <summary>The player's annotations.</summary>
    public IEnumerable<PlayerAnnotation>? Annotations { get; init; }
}