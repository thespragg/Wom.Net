using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group.
/// </summary>
[PublicAPI]
public record Group
{
    /// <summary>The group's ID.</summary>
    public int Id { get; init; }

    /// <summary>The group's name.</summary>
    public string Name { get; init; } = null!;

    /// <summary>The group's clan chat (1-12 characters).</summary>
    public string ClanChat { get; init; } = null!;

    /// <summary>The group's description.</summary>
    public string? Description { get; init; }

    /// <summary>The group's homeworld.</summary>
    public int? Homeworld { get; init; }

    /// <summary>The group's verified status.</summary>
    public bool Verified { get; init; }

    /// <summary>The group's patronage status (subscribed to our Patreon).</summary>
    public bool Patron { get; init; }

    /// <summary>The group's profile image (Patreon exclusive).</summary>
    public string? ProfileImage { get; init; }

    /// <summary>The group's banner image (Patreon exclusive).</summary>
    public string? BannerImage { get; init; }

    /// <summary>The group's global ranking score.</summary>
    public int Score { get; init; }

    /// <summary>The group's creation date.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The group's last modification date.</summary>
    public DateTime UpdatedAt { get; init; }

    /// <summary>The group's total number of members.</summary>
    public int MemberCount { get; init; }
}