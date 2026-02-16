using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Enums;

/// <summary>
/// Represents the type of activity in a group.
/// </summary>
[PublicAPI]
public enum ActivityType
{
    /// <summary>Player joined the group.</summary>
    Joined,

    /// <summary>Player left the group.</summary>
    Left,

    /// <summary>Player's role (rank) changed in the group.</summary>
    ChangedRole
}