using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a competition with its participations.
/// </summary>
[PublicAPI]
public sealed record CompetitionWithParticipations : Competition
{
    /// <summary>The competition's participants.</summary>
    public CompetitionParticipation[] Participations { get; init; } = [];
}