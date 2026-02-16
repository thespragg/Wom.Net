using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a player's membership with group details.
/// </summary>
[PublicAPI]
public sealed record PlayerMembership : Membership
{
    /// <summary>The group the player is a member in.</summary>
    public Group Group { get; init; } = null!;
}