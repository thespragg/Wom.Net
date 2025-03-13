using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents metric leaders in a group.
/// </summary>
[PublicAPI]
public sealed record MetricLeaders
{
    /// <summary>Skill leaders.</summary>
    public Dictionary<string, SkillLeader> Skills { get; init; } = [];

    /// <summary>Boss leaders.</summary> = null!;
    public Dictionary<string, BossLeader> Bosses { get; init; } = [];

    /// <summary>Activity leaders.</summary>
    public Dictionary<string, ActivityLeader> Activities { get; init; } = [];

    /// <summary>Computed metric leaders.</summary>
    public Dictionary<string, ComputedMetricLeader> Computed { get; init; } = [];
}