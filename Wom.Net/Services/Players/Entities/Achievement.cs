using JetBrains.Annotations;
using Wom.Net.Services.Players.Enums;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents an achievement.
/// </summary>
[PublicAPI]
public record Achievement
{
    /// <summary>The parent player's ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The achievement's description or name.</summary>
    public string Name { get; init; } = null!;

    /// <summary>The achievement's metric (e.g., agility).</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The achievement's measure (e.g., experience).</summary>
    public AchievementMeasure Measure { get; init; }

    /// <summary>The achievement's threshold value.</summary>
    public long Threshold { get; init; }

    /// <summary>The achievement's creation date.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The accuracy of the creation date (margin of error in milliseconds).</summary>
    public long? Accuracy { get; init; }
}
