using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group hiscores entry.
/// </summary>
[PublicAPI]
public sealed record GroupHiscoresEntry
{
    /// <summary>The hiscores entry's parent player.</summary>
    public Player Player { get; init; } = null!;

    /// <summary>The player's hiscores values for a specific metric.</summary>
    public object Data { get; init; }  = null!;
}