using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a competition participation with player details.
/// </summary>
[PublicAPI]
public record CompetitionParticipation : Participation
{
    /// <summary>The participation's player.</summary>
    public Player Player { get; init; } = null!;
}