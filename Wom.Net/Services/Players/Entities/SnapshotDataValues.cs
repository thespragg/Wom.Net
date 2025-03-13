namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents the data values for a player snapshot.
/// </summary>
public sealed record SnapshotDataValues
{
    /// <summary>Skills data for the snapshot.</summary>
    public SkillsData Skills { get; init; }

    /// <summary>Bosses data for the snapshot.</summary>
    public BossesData Bosses { get; init; }

    /// <summary>Activities data for the snapshot.</summary>
    public ActivitiesData Activities { get; init; }

    /// <summary>Computed metrics for the snapshot.</summary>
    public ComputedData Computed { get; init; }
}