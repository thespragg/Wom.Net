using JetBrains.Annotations;

namespace Wom.Net.Services.Groups.Entities;

/// <summary>
/// Represents a group delta progress.
/// </summary>
[PublicAPI]
public sealed record GroupDeltaProgress
{
    /// <summary>A player's start value for some time period.</summary>
    public int Start { get; init; }

    /// <summary>A player's end value for some time period.</summary>
    public int End { get; init; }

    /// <summary>A player's gained value for some time period.</summary>
    public int Gained { get; init; }
}