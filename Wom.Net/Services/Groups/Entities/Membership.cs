using JetBrains.Annotations;
using Wom.Net.Services.Groups.Enums;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a membership in a group.
/// </summary>
[PublicAPI]
public record Membership
{
    /// <summary>The player's ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The group's ID.</summary>
    public int GroupId { get; init; }

    /// <summary>The player's role (rank) in the group.</summary>
    public GroupRole? Role { get; init; }

    /// <summary>The date at which the player was added as a member to the group.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The date at which the membership was updated.</summary>
    public DateTime UpdatedAt { get; init; }
}