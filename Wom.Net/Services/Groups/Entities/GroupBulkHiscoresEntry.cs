using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group bulk hiscores entry.
/// </summary>
[PublicAPI]
public sealed record GroupBulkHiscoresEntry
{
    /// <summary>The hiscores entry's parent player.</summary>
    public Player Player { get; init; } = null!;

    /// <summary>The player's latest snapshot.</summary>
    public Snapshot Data { get; init; } = null!;
}