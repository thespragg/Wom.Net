using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents skill-specific data.
/// </summary>
[PublicAPI]
public sealed record SkillsData
{
    /// <summary>Overall skill data.</summary>
    public SkillData Overall { get; init; } = null!;

    /// <summary>Attack skill data.</summary>
    public SkillData Attack { get; init; } = null!;

    /// <summary>Defence skill data.</summary>
    public SkillData Defence { get; init; } = null!;

    /// <summary>Strength skill data.</summary>
    public SkillData Strength { get; init; } = null!;

    /// <summary>Hitpoints skill data.</summary>
    public SkillData Hitpoints { get; init; } = null!;

    /// <summary>Ranged skill data.</summary>
    public SkillData Ranged { get; init; } = null!;

    /// <summary>Prayer skill data.</summary>
    public SkillData Prayer { get; init; } = null!;

    /// <summary>Magic skill data.</summary>
    public SkillData Magic { get; init; } = null!;

    /// <summary>Cooking skill data.</summary>
    public SkillData Cooking { get; init; } = null!;

    /// <summary>Woodcutting skill data.</summary>
    public SkillData Woodcutting { get; init; } = null!;

    /// <summary>Fletching skill data.</summary>
    public SkillData Fletching { get; init; } = null!;

    /// <summary>Fishing skill data.</summary>
    public SkillData Fishing { get; init; } = null!;

    /// <summary>Firemaking skill data.</summary>
    public SkillData Firemaking { get; init; } = null!;

    /// <summary>Crafting skill data.</summary>
    public SkillData Crafting { get; init; } = null!;

    /// <summary>Smithing skill data.</summary>
    public SkillData Smithing { get; init; } = null!;

    /// <summary>Mining skill data.</summary>
    public SkillData Mining { get; init; } = null!;

    /// <summary>Herblore skill data.</summary>
    public SkillData Herblore { get; init; } = null!;

    /// <summary>Agility skill data.</summary>
    public SkillData Agility { get; init; } = null!;

    /// <summary>Thieving skill data.</summary>
    public SkillData Thieving { get; init; } = null!;

    /// <summary>Slayer skill data.</summary>
    public SkillData Slayer { get; init; } = null!;

    /// <summary>Farming skill data.</summary>
    public SkillData Farming { get; init; } = null!;

    /// <summary>Runecrafting skill data.</summary>
    public SkillData Runecrafting { get; init; } = null!;

    /// <summary>Hunter skill data.</summary>
    public SkillData Hunter { get; init; } = null!;

    /// <summary>Construction skill data.</summary>
    public SkillData Construction { get; init; } = null!;
}

/// <summary>
/// Represents a skill's data.
/// </summary>
[PublicAPI]
public sealed record SkillData
{
    /// <summary>The skill's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The skill's Efficient Hours Played (EHP).</summary>
    public double Ehp { get; init; }

    /// <summary>The skill's rank.</summary>
    public int Rank { get; init; }

    /// <summary>The skill's level.</summary>
    public int Level { get; init; }

    /// <summary>The skill's experience.</summary>
    public long Experience { get; init; }
}