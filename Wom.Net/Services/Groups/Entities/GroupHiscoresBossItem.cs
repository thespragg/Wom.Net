using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group hiscores boss item.
/// </summary>
[PublicAPI]
public sealed record GroupHiscoresBossItem
{
    /// <summary>The type of this hiscores item ('boss').</summary>
    public string Type { get; init; } = "boss";

    /// <summary>The player's rank in a specific boss.</summary>
    public int Rank { get; init; }

    /// <summary>The player's kills for a specific boss.</summary>
    public int Kills { get; init; }
}