using JetBrains.Annotations;

namespace Wom.Net.Services.Competitions.Enums;

/// <summary>
/// The status of the competition
/// </summary>
[PublicAPI]
public enum CompetitionStatus
{
    Upcoming,
    Ongoing,
    Finished
}