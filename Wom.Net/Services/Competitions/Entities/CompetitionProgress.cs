using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a player's progress in a competition.
/// </summary>
[PublicAPI]
public sealed record CompetitionProgress
{
    /// <summary>A player's start value for the competition's metric.</summary>
    public int Start { get; init; }

    /// <summary>A player's end value for the competition's metric.</summary>
    public int End { get; init; }

    /// <summary>A player's gained value for the competition's metric.</summary>
    public int Gained { get; init; }
}