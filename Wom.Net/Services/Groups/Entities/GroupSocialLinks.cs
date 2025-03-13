using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group's social links.
/// </summary>
[PublicAPI]
public sealed record GroupSocialLinks
{
    /// <summary>The group's website URL.</summary>
    public string? Website { get; init; }

    /// <summary>The group's Discord URL.</summary>
    public string? Discord { get; init; }

    /// <summary>The group's Twitter URL.</summary>
    public string? Twitter { get; init; }

    /// <summary>The group's YouTube URL.</summary>
    public string? Youtube { get; init; }

    /// <summary>The group's Twitch URL.</summary>
    public string? Twitch { get; init; }
}