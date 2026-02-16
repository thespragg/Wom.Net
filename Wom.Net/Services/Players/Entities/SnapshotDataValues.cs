using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents the data values for a player snapshot.
/// </summary>
[PublicAPI]
public sealed record SnapshotDataValues
{
    /// <summary>Skills data for the snapshot.</summary>
    public SkillsData Skills { get; init; } = null!;

    /// <summary>Bosses data for the snapshot.</summary>
    public BossesData Bosses { get; init; } = null!;

    /// <summary>Activities data for the snapshot.</summary>
    public ActivitiesData Activities { get; init; } = null!;

    /// <summary>Computed metrics for the snapshot.</summary>
    public ComputedData Computed { get; init; } = null!;
}