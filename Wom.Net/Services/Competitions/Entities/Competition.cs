using JetBrains.Annotations;
using Wom.Net.Services.Competitions.Enums;
using Wom.Net.Services.Groups.Entities;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a competition.
/// </summary>
[PublicAPI]
public record Competition
{
    /// <summary>The competition's unique ID.</summary>
    public int Id { get; init; }

    /// <summary>The competition's title.</summary>
    public string Title { get; init; } = null!;

    /// <summary>The competition's metric.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The competition's type.</summary>
    public CompetitionType Type { get; init; }

    /// <summary>The competition's start date.</summary>
    public DateTime StartsAt { get; init; }

    /// <summary>The competition's end date.</summary>
    public DateTime EndsAt { get; init; }

    /// <summary>The competition's host group ID.</summary>
    public int? GroupId { get; init; }

    /// <summary>The competition's global ranking score.</summary>
    public int Score { get; init; }

    /// <summary>The competition's creation date.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The competition's last modification date.</summary>
    public DateTime UpdatedAt { get; init; }

    /// <summary>The competition's total number of participants.</summary>
    public int ParticipantCount { get; init; }

    /// <summary>The competition's host group.</summary>
    public Group Group { get; init; } = null!;
}
