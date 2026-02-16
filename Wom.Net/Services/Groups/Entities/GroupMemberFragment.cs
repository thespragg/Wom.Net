using JetBrains.Annotations;
using Wom.Net.Services.Groups.Enums;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group member fragment used for group modification endpoints.
/// </summary>
[PublicAPI]
public sealed record GroupMemberFragment
{
    /// <summary>The player's username.</summary>
    public string Username { get; init; } = null!;

    /// <summary>The player's role (rank) in the group.</summary>
    public GroupRole? Role { get; init; }
}