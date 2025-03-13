using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Entities;

/// <summary>
/// Represents a team in a competition.
/// </summary>
[PublicAPI]
public sealed record Team
{
    /// <summary>The team's name.</summary>
    public string Name { get; init; } = null!;

    /// <summary>The team's participants' usernames.</summary>
    public string[] Participants { get; init; } = [];
}