using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a skill leader in a group.
/// </summary>
[PublicAPI]
public sealed record SkillLeader
{
    /// <summary>The skill's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The player's Efficient Hours Played (EHP) in this skill.</summary>
    public double Ehp { get; init; }

    /// <summary>The player's rank in this skill.</summary>
    public int Rank { get; init; }

    /// <summary>The player's level in this skill.</summary>
    public int Level { get; init; }

    /// <summary>The player's experience in this skill.</summary>
    public long Experience { get; init; }

    /// <summary>The player who leads in this skill.</summary>
    public Player Player { get; init; } = null!;
}