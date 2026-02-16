using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents a snapshot of a player's progress over a specific time period.
/// </summary>
[PublicAPI]
public sealed record PlayerProgressSnapshot
{
    /// <summary>The start date of the snapshot period.</summary>
    public DateTime StartsAt { get; init; }

    /// <summary>The end date of the snapshot period.</summary>
    public DateTime EndsAt { get; init; }

    /// <summary>The data for the snapshot, including skills, bosses, activities, and computed metrics.</summary>
    public SnapshotData Data { get; init; } = null!;
}

/// <summary>
/// Represents the data for a player's progress snapshot.
/// </summary>
[PublicAPI]
public sealed record SnapshotData
{
    /// <summary>Skill-related progress data.</summary>
    public Dictionary<string, SkillProgress> Skills { get; init; } = null!;

    /// <summary>Boss-related progress data.</summary>
    public Dictionary<string, BossProgress> Bosses { get; init; } = null!;

    /// <summary>Activity-related progress data.</summary>
    public Dictionary<string, ActivityProgress> Activities { get; init; } = null!;

    /// <summary>Computed metric-related progress data.</summary>
    public Dictionary<string, ComputedMetricProgress> Computed { get; init; } = null!;
}

/// <summary>
/// Represents progress data for a skill.
/// </summary>
[PublicAPI]
public sealed record SkillProgress
{
    /// <summary>The skill's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The experience progress for the skill.</summary>
    public ProgressValue Experience { get; init; } = null!;

    /// <summary>The Efficient Hours Played (EHP) progress for the skill.</summary>
    public ProgressValue Ehp { get; init; } = null!;

    /// <summary>The rank progress for the skill.</summary>
    public ProgressValue Rank { get; init; } = null!;

    /// <summary>The level progress for the skill.</summary>
    public ProgressValue Level { get; init; } = null!;
}

/// <summary>
/// Represents progress data for a boss.
/// </summary>
[PublicAPI]
public sealed record BossProgress
{
    /// <summary>The boss's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The Efficient Hours Bossed (EHB) progress for the boss.</summary>
    public ProgressValue Ehb { get; init; } = null!;

    /// <summary>The rank progress for the boss.</summary>
    public ProgressValue Rank { get; init; } = null!;

    /// <summary>The kills progress for the boss.</summary>
    public ProgressValue Kills { get; init; } = null!;
}

/// <summary>
/// Represents progress data for an activity.
/// </summary>
[PublicAPI]
public sealed record ActivityProgress
{
    /// <summary>The activity's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The rank progress for the activity.</summary>
    public ProgressValue Rank { get; init; } = null!;

    /// <summary>The score progress for the activity.</summary>
    public ProgressValue Score { get; init; } = null!;
}

/// <summary>
/// Represents progress data for a computed metric.
/// </summary>
[PublicAPI]
public sealed record ComputedMetricProgress
{
    /// <summary>The computed metric's name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The value progress for the computed metric.</summary>
    public ProgressValue Value { get; init; } = null!;

    /// <summary>The rank progress for the computed metric.</summary>
    public ProgressValue Rank { get; init; } = null!;
}

/// <summary>
/// Represents a progress value with start, end, and gained values.
/// </summary>
[PublicAPI]
public sealed record ProgressValue
{
    /// <summary>The value gained during the period.</summary>
    public double Gained { get; init; }

    /// <summary>The value at the start of the period.</summary>
    public double Start { get; init; }

    /// <summary>The value at the end of the period.</summary>
    public double End { get; init; }
}