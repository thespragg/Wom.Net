using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents competition participation details.
/// </summary>
[PublicAPI]
public sealed record CompetitionParticipationDetails : CompetitionParticipation
{
    /// <summary>The player's progress in the competition.</summary>
    public CompetitionProgress Progress { get; init; } = null!;

    /// <summary>The player's levels progress in the competition. (Only exists in skilling competitions)</summary>
    public CompetitionLevelProgress? Levels { get; init; }
}