using JetBrains.Annotations;
using Wom.Net.Enums;

namespace Wom.Net.Services.Records.Entities;

/// <summary>
/// Represents a record of a player's progress for a specific metric and time period.
/// </summary>
[PublicAPI]
public record Record
{
    /// <summary>The record's unique ID.</summary>
    public int Id { get; init; }

    /// <summary>The record's parent player ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The record's time period.</summary>
    public Period Period { get; init; }

    /// <summary>The record's metric.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The record's value (gained value).</summary>
    public long Value { get; init; }

    /// <summary>The record's creation/modification date.</summary>
    public DateTime UpdatedAt { get; init; }
}