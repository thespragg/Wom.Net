namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents activity-specific data.
/// </summary>
public sealed record ActivitiesData
{
    /// <summary>League Points activity data.</summary>
    public ActivityData LeaguePoints { get; init; }

    /// <summary>Bounty Hunter Hunter activity data.</summary>
    public ActivityData BountyHunterHunter { get; init; }

    /// <summary>Bounty Hunter Rogue activity data.</summary>
    public ActivityData BountyHunterRogue { get; init; }

    /// <summary>Clue Scrolls All activity data.</summary>
    public ActivityData ClueScrollsAll { get; init; }

    /// <summary>Clue Scrolls Beginner activity data.</summary>
    public ActivityData ClueScrollsBeginner { get; init; }

    /// <summary>Clue Scrolls Easy activity data.</summary>
    public ActivityData ClueScrollsEasy { get; init; }

    /// <summary>Clue Scrolls Medium activity data.</summary>
    public ActivityData ClueScrollsMedium { get; init; }

    /// <summary>Clue Scrolls Hard activity data.</summary>
    public ActivityData ClueScrollsHard { get; init; }

    /// <summary>Clue Scrolls Elite activity data.</summary>
    public ActivityData ClueScrollsElite { get; init; }

    /// <summary>Clue Scrolls Master activity data.</summary>
    public ActivityData ClueScrollsMaster { get; init; }

    /// <summary>Last Man Standing activity data.</summary>
    public ActivityData LastManStanding { get; init; }

    /// <summary>PvP Arena activity data.</summary>
    public ActivityData PvpArena { get; init; }

    /// <summary>Soul Wars Zeal activity data.</summary>
    public ActivityData SoulWarsZeal { get; init; }

    /// <summary>Guardians of the Rift activity data.</summary>
    public ActivityData GuardiansOfTheRift { get; init; }

    /// <summary>Colosseum Glory activity data.</summary>
    public ActivityData ColosseumGlory { get; init; }

    /// <summary>Collections Logged activity data.</summary>
    public ActivityData CollectionsLogged { get; init; }
}

/// <summary>
/// Represents an activity's data.
/// </summary>
public sealed record ActivityData
{
    /// <summary>The activity's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The activity's rank.</summary>
    public int Rank { get; init; }

    /// <summary>The activity's score.</summary>
    public int Score { get; init; }
}