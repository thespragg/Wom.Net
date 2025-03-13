using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents a player's progress toward an achievement.
/// </summary>
[PublicAPI]
public sealed record PlayerAchievementProgress : Achievement
{
    /// <summary>The player's current value for the achievement's metric and measure.</summary>
    public int CurrentValue { get; init; }

    /// <summary>The player's absolute progress toward the achievement (0-1).</summary>
    public float AbsoluteProgress { get; init; }

    /// <summary>The player's relative progress toward the achievement (0-1).</summary>
    public float RelativeProgress { get; init; }
}