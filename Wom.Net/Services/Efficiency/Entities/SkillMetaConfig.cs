using JetBrains.Annotations;

namespace Wom.Net.Services.Efficiency.Entities;

/// <summary>
/// Represents the configuration for calculating EHP (Efficient Hours Played) for a skill.
/// </summary>
[PublicAPI]
public sealed record SkillMetaConfig
{
    /// <summary>The skill being configured.</summary>
    public string Skill { get; init; } = null!;

    /// <summary>An array of skill methods used to calculate EHP.</summary>
    public SkillMetaMethod[] Methods { get; init; } = null!;

    /// <summary>A list of bonuses the skill gives to other skills.</summary>
    public Bonus[] Bonuses { get; init; } = null!;
}