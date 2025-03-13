using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a player's participation in a competition.
/// </summary>
[PublicAPI]
public record Participation
{
    /// <summary>The player's ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The competition's ID.</summary>
    public int CompetitionId { get; init; }

    /// <summary>The name of the team the player is in. (Only applicable to team competitions)</summary>
    public string? TeamName { get; init; }

    /// <summary>The date at which the player was added as a participant to the competition.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The date at which the participation was updated.</summary>
    public DateTime UpdatedAt { get; init; }
}