using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group hiscores activity item.
/// </summary>
[PublicAPI]
public sealed record GroupHiscoresActivityItem
{
    /// <summary>The type of this hiscores item ('activity').</summary>
    public string Type { get; init; } = "activity";

    /// <summary>The player's rank in a specific activity.</summary>
    public int Rank { get; init; }

    /// <summary>The player's score in a specific activity.</summary>
    public int Score { get; init; }
}