using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a player's standing in a competition.
/// </summary>
[PublicAPI]
public sealed record PlayerCompetitionStanding : PlayerParticipation
{
    /// <summary>The player's progress in the competition.</summary>
    public CompetitionProgress Progress { get; init; } = null!;

    /// <summary>The player's levels progress in the competition. (Only exists in skilling competitions)</summary>
    public CompetitionLevelProgress? Levels { get; init; }

    /// <summary>The player's rank in the competition.</summary>
    public int Rank { get; init; }
}