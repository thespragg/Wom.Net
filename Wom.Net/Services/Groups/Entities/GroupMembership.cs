using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group membership with player details.
/// </summary>
[PublicAPI]
public sealed record GroupMembership : Membership
{
    /// <summary>The membership's player.</summary>
    public Player Player { get; init; } = null!;
}