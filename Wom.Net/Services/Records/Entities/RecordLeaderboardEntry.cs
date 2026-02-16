using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Records.Entities;

/// <summary>
/// Represents a record leaderboard entry, extending the <see cref="Record"/> object.
/// </summary>
[PublicAPI]
public sealed record RecordLeaderboardEntry : Record
{
    /// <summary>The record's parent player.</summary>
    public Player Player { get; init; } = null!;
}