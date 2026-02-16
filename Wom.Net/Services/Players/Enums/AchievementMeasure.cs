using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Enums;

/// <summary>
/// Represents the measure used for achievements.
/// </summary>
[PublicAPI]
public enum AchievementMeasure
{
    /// <summary>Achievement measured by levels.</summary>
    Levels,
    /// <summary>Achievement measured by experience.</summary>
    Experience,
    /// <summary>Achievement measured by kills.</summary>
    Kills,
    /// <summary>Achievement measured by score.</summary>
    Score,
    /// <summary>Achievement measured by value.</summary>
    Value
}