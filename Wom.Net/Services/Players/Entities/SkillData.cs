namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents skill-specific data.
/// </summary>
public sealed record SkillsData
{
    /// <summary>Overall skill data.</summary>
    public SkillData Overall { get; init; }

    /// <summary>Attack skill data.</summary>
    public SkillData Attack { get; init; }

    /// <summary>Defence skill data.</summary>
    public SkillData Defence { get; init; }

    /// <summary>Strength skill data.</summary>
    public SkillData Strength { get; init; }

    /// <summary>Hitpoints skill data.</summary>
    public SkillData Hitpoints { get; init; }

    /// <summary>Ranged skill data.</summary>
    public SkillData Ranged { get; init; }

    /// <summary>Prayer skill data.</summary>
    public SkillData Prayer { get; init; }

    /// <summary>Magic skill data.</summary>
    public SkillData Magic { get; init; }

    /// <summary>Cooking skill data.</summary>
    public SkillData Cooking { get; init; }

    /// <summary>Woodcutting skill data.</summary>
    public SkillData Woodcutting { get; init; }

    /// <summary>Fletching skill data.</summary>
    public SkillData Fletching { get; init; }

    /// <summary>Fishing skill data.</summary>
    public SkillData Fishing { get; init; }

    /// <summary>Firemaking skill data.</summary>
    public SkillData Firemaking { get; init; }

    /// <summary>Crafting skill data.</summary>
    public SkillData Crafting { get; init; }

    /// <summary>Smithing skill data.</summary>
    public SkillData Smithing { get; init; }

    /// <summary>Mining skill data.</summary>
    public SkillData Mining { get; init; }

    /// <summary>Herblore skill data.</summary>
    public SkillData Herblore { get; init; }

    /// <summary>Agility skill data.</summary>
    public SkillData Agility { get; init; }

    /// <summary>Thieving skill data.</summary>
    public SkillData Thieving { get; init; }

    /// <summary>Slayer skill data.</summary>
    public SkillData Slayer { get; init; }

    /// <summary>Farming skill data.</summary>
    public SkillData Farming { get; init; }

    /// <summary>Runecrafting skill data.</summary>
    public SkillData Runecrafting { get; init; }

    /// <summary>Hunter skill data.</summary>
    public SkillData Hunter { get; init; }

    /// <summary>Construction skill data.</summary>
    public SkillData Construction { get; init; }
}

/// <summary>
/// Represents a skill's data.
/// </summary>
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