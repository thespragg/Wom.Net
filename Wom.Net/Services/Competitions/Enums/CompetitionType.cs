using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Enums;

/// <summary>
/// Represents the type of competition.
/// </summary>
[PublicAPI]
public enum CompetitionType
{
    /// <summary>Classic competition type.</summary>
    Classic,

    /// <summary>Team-based competition type.</summary>
    Team
}