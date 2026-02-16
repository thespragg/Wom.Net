using JetBrains.Annotations;

namespace Wom.Net.Services.Efficiency.Entities;

/// <summary>
/// Represents a method for calculating EHP (Efficient Hours Played) for a skill.
/// </summary>
[PublicAPI]
public sealed record SkillMetaMethod
{
    /// <summary>What exp to start calculating EHP from.</summary>
    public double StartExp { get; init; }

    /// <summary>The exp per hour for the method.</summary>
    public double Rate { get; init; }

    /// <summary>Scaled exp per hour for the method based on bonuses received.</summary>
    public double? RealRate { get; init; }

    /// <summary>The description of the method.</summary>
    public string Description { get; init; } = null!;
}