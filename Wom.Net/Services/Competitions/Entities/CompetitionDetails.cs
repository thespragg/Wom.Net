using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents detailed information about a competition.
/// </summary>
[PublicAPI]
public sealed record CompetitionDetails : Competition
{
    /// <summary>The competition's participants, and all their progress.</summary>
    public CompetitionParticipationDetails[] Participations { get; init; } =[];
}
