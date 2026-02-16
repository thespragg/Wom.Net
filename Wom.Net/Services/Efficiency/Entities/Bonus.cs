using JetBrains.Annotations;

namespace Wom.Net.Services.Efficiency.Entities;

/// <summary>
/// Represents a bonus that one skill provides to another.
/// </summary>
[PublicAPI]
public sealed record Bonus
{
    /// <summary>The skill that gives the bonus.</summary>
    public string OriginSkill { get; init; } = null!;

    /// <summary>The skill that receives the bonus.</summary>
    public string BonusSkill { get; init; } = null!;

    /// <summary>Start exp of origin skill for which bonus skill starts receiving bonus exp.</summary>
    public double StartExp { get; init; }

    /// <summary>End exp of origin skill for which bonus skill stops receiving bonus exp.</summary>
    public double EndExp { get; init; }

    /// <summary>Calculated max bonus a bonus skill can receive from origin skill.</summary>
    public double? MaxBonus { get; init; }

    /// <summary>Whether the bonus exp is added at the end when calculating EHP for the bonus skill.</summary>
    public bool End { get; init; }

    /// <summary>The ratio of bonus xp given to bonus skill per exp in origin skill.</summary>
    public double Ratio { get; init; }
}