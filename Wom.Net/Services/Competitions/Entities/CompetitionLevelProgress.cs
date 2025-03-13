using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a player's levels progress in a competition.
/// </summary>
[PublicAPI]
public sealed record CompetitionLevelProgress
{
    /// <summary>A player's start level for the competition's metric.</summary>
    public int Start { get; init; }

    /// <summary>A player's end level for the competition's metric.</summary>
    public int End { get; init; }

    /// <summary>A player's gained levels for the competition's metric.</summary>
    public int Gained { get; init; }
}