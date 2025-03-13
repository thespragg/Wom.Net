using System.Collections;
using Functional.Sharp.Monads;
using JetBrains.Annotations;
using Wom.Net.Enums;
using Wom.Net.Services.Competitions.Entities;
using Wom.Net.Services.Competitions.Enums;
using Wom.Net.Services.Groups.Entities;
using Wom.Net.Services.Players.Entities;
using Wom.Net.Services.Players.Responses;

namespace Wom.Net.Contracts;

[PublicAPI]
public interface IPlayersService
{
    Task<Result<IEnumerable<GetPlayerResponse>>> Search(
        string username,
        int? limit = default,
        int? offset = default,
        CancellationToken cancellationToken = default
    );

    Task<Result<GetPlayerDetailsResponse>> Update(
        string username,
        CancellationToken cancellationToken = default
    );

    Task<Result<AssertPlayerTypeResponse>> AssertType(
        string username,
        CancellationToken cancellationToken = default
    );

    Task<Result<GetPlayerDetailsResponse>> PlayerDetails(
        string username,
        CancellationToken cancellationToken = default
    );

    Task<Result<GetPlayerDetailsResponse>> PlayerDetails(
        int id,
        CancellationToken cancellationToken = default
    );

    Task<Result<IEnumerable<GetAchievementResponse>>> Achievements(
        string username,
        CancellationToken cancellationToken = default
    );

    Task<Result<IEnumerable<GetAchievementProgressResponse>>> AchievementsProgress(
        string username,
        CancellationToken cancellationToken = default
    );

    Task<Result<IEnumerable<PlayerParticipation>>> Competitions(
        string username,
        CompetitionStatus? competitionStatus = null,
        int? limit = null,
        int? offset = null,
        CancellationToken cancellationToken = default
    );

    Task<Result<IEnumerable<PlayerCompetitionStanding>>> CompetitionStandings(
        string username,
        CompetitionStatus? competitionStatus = null,
        CancellationToken cancellationToken = default
    );

    Task<Result<IEnumerable<PlayerMembership>>> GroupMemberships(
        string username,
        int? limit = null,
        int? offset = null,
        CancellationToken cancellationToken = default
    );

    Task<Result<PlayerProgressSnapshot>> Gains(
        string username,
        Period period,
        CancellationToken cancellationToken = default
    );

    Task<Result<PlayerProgressSnapshot>> Gains(
        string username,
        DateTime startDate,
        DateTime endDate,
        CancellationToken cancellationToken = default
    );
}