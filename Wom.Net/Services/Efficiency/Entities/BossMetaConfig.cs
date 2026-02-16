using JetBrains.Annotations;

namespace Wom.Net.Services.Efficiency.Entities;

/// <summary>
/// Represents the configuration for calculating EHB (Efficient Hours Bossed) for a boss.
/// </summary>
[PublicAPI]
public sealed record BossMetaConfig
{
    /// <summary>The boss being configured.</summary>
    public string Boss { get; init; } = null!;

    /// <summary>The kills per hour for the boss.</summary>
    public double Rate { get; init; }
}