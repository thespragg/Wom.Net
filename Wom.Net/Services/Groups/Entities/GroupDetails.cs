using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents detailed information about a group.
/// </summary>
[PublicAPI]
public sealed record GroupDetails : Group
{
    /// <summary>The group's memberships.</summary>
    public GroupMembership[] Memberships { get; init; } = [];

    /// <summary>The group's social links (Patreon exclusive).</summary>
    public GroupSocialLinks SocialLinks { get; init; } = null!;
}