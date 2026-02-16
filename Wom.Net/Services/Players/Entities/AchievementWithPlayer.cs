using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents an achievement with associated player information.
/// </summary>
[PublicAPI]
public sealed record AchievementWithPlayer : Achievement
{
    /// <summary>The player associated with the achievement.</summary>
    public Player Player { get; init; } = null!;
}
