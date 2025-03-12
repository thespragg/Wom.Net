using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Enums;

/// <summary>
/// Represents annotations or flags associated with a player account.
/// </summary>
[PublicAPI]
public enum PlayerAnnotation
{
    /// <summary>Player has opted out of certain features.</summary>
    OptOut,
    /// <summary>Player is blocked.</summary>
    Blocked,
    /// <summary>Player is flagged as a fake free-to-play account.</summary>
    FakeF2P
}