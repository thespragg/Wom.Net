using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Enums;

/// <summary>
/// Represents the status of a player account.
/// </summary>
[PublicAPI]
public enum PlayerStatus
{
    /// <summary>Active player account.</summary>
    Active,
    /// <summary>Unranked player account.</summary>
    Unranked,
    /// <summary>Flagged player account.</summary>
    Flagged,
    /// <summary>Archived player account.</summary>
    Archived,
    /// <summary>Banned player account.</summary>
    Banned
}