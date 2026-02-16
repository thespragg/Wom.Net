using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a top 5 progress result in a competition.
/// </summary>
[PublicAPI]
public sealed record Top5ProgressResult
{
    /// <summary>The participant.</summary>
    public Player Player { get; init; } = null!;

    /// <summary>The participant's history throughout the competition.</summary>
    public CompetitionHistoryDatapoint[] History { get; init; } = null!;
}