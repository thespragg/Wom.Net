using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group hiscores skill item.
/// </summary>
[PublicAPI]
public sealed record GroupHiscoresSkillItem
{
    /// <summary>The type of this hiscores item ('skill').</summary>
    public string Type { get; init; } = "skill";

    /// <summary>The player's rank in a specific skill.</summary>
    public int Rank { get; init; }

    /// <summary>The player's level in a specific skill.</summary>
    public int Level { get; init; }

    /// <summary>The player's experience in a specific skill.</summary>
    public long Experience { get; init; }
}