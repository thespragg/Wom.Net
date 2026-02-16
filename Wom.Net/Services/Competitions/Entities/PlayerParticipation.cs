using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a player's participation with competition details.
/// </summary>
[PublicAPI]
public record PlayerParticipation : Participation
{
    /// <summary>The competition the player is competing in.</summary>
    public Competition Competition { get; init; } = null!;
}