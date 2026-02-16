using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;


/// <summary>
/// Represents a boss leader in a group.
/// </summary>
[PublicAPI]
public sealed record BossLeader
{
    /// <summary>The boss's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The player's Efficient Hours Bossed (EHB) for this boss.</summary>
    public double Ehb { get; init; }

    /// <summary>The player's rank for this boss.</summary>
    public int Rank { get; init; }

    /// <summary>The player's kills for this boss.</summary>
    public int Kills { get; init; }

    /// <summary>The player who leads in this boss.</summary>
    public Player Player { get; init; } = null!;
}