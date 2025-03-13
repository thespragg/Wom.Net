using JetBrains.Annotations;
using Wom.Net.Services.Groups.Enums;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group activity.
/// </summary>
[PublicAPI]
public sealed record GroupActivity
{
    /// <summary>The group's ID.</summary>
    public int GroupId { get; init; }

    /// <summary>The player's ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The type of activity.</summary>
    public ActivityType Type { get; init; }

    /// <summary>The player's role (rank) in the group.</summary>
    public GroupRole? Role { get; init; }

    /// <summary>The date at which the activity happened.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The activity entry's parent player object.</summary>
    public Player Player { get; init; } = null!;
}