using System.Collections.Concurrent;
using Functional.Sharp.Extensions;
using Functional.Sharp.Helpers;
using Functional.Sharp.Monads;
using Microsoft.Extensions.Logging;
using Wom.Net.Contracts;
using Wom.Net.Enums;
using Wom.Net.Extensions;
using Wom.Net.Services.Competitions.Entities;
using Wom.Net.Services.Competitions.Enums;
using Wom.Net.Services.Groups.Entities;
using Wom.Net.Services.Players.Entities;
using Wom.Net.Services.Players.Responses;
using Wom.Net.Utils;

namespace Wom.Net.Services.Players;

internal class PlayersService(HttpClient client, ILogger<PlayersService> logger) : IPlayersService
{
    private static readonly ConcurrentDictionary<string, DateTimeOffset> LastUpdateTimes = new(StringComparer.OrdinalIgnoreCase);
    private static readonly TimeSpan MinUpdateInterval = TimeSpan.FromMinutes(10);
    public async Task<Result<IEnumerable<GetPlayerResponse>>> Search(
        string username,
        int? limit = default,
        int? offset = default,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
            await new HttpClientBuilder(client)
                .WithRoute("players")
                .WithRoute("search")
                .WithQueryParameter("username", username)
                .WithQueryParameter("limit", limit)
                .WithQueryParameter("offset", offset)
                .ExecuteGetAsync(cancellationToken)
                .ToTypedResultAsync<IEnumerable<GetPlayerResponse>>(cancellationToken))
        .FlattenAsync();

    public async Task<Result<GetPlayerDetailsResponse>> Update(
        string username,
        CancellationToken cancellationToken = default
    )
    {
        var now = DateTimeOffset.UtcNow;

        if (LastUpdateTimes.TryGetValue(username, out var lastUpdate))
        {
            var elapsed = now - lastUpdate;
            if (elapsed < MinUpdateInterval)
                logger.LogWarning(
                    "Player '{Username}' was last updated {Elapsed:F1} minutes ago (< 10 min). " +
                    "Frequent updates may result in an IP ban. Consider using a longer interval (1-6 hours)",
                    username, elapsed.TotalMinutes);
        }

        LastUpdateTimes[username] = now;

        return await Try.ExecuteAsync(async () =>
            await new HttpClientBuilder(client)
                .WithRoute("players")
                .WithRoute(username)
                .ExecutePostAsync(cancellationToken: cancellationToken)
                .ToTypedResultAsync<GetPlayerDetailsResponse>(cancellationToken)
        ).FlattenAsync();
    }

    public async Task<Result<AssertPlayerTypeResponse>> AssertType(
        string username,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .WithRoute("assert-type")
            .ExecutePostAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<AssertPlayerTypeResponse>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<GetPlayerDetailsResponse>> PlayerDetails(
        string username,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<GetPlayerDetailsResponse>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<GetPlayerDetailsResponse>> PlayerDetails(
        int id,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute("id")
            .WithRoute(id.ToString())
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<GetPlayerDetailsResponse>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<IEnumerable<GetAchievementResponse>>> Achievements(
        string username,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .WithRoute("achievements")
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<IEnumerable<GetAchievementResponse>>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<IEnumerable<GetAchievementProgressResponse>>> AchievementsProgress(
        string username,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .WithRoute("achievements")
            .WithRoute("progress")
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<IEnumerable<GetAchievementProgressResponse>>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<IEnumerable<PlayerParticipation>>> Competitions(
        string username,
        CompetitionStatus? competitionStatus = null,
        int? limit = null,
        int? offset = null,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .WithRoute("competitions")
            .WithQueryParameter("status", competitionStatus?.ToString().ToLower())
            .WithQueryParameter("limit", limit)
            .WithQueryParameter("offset", offset)
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<IEnumerable<PlayerParticipation>>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<IEnumerable<PlayerCompetitionStanding>>> CompetitionStandings(
        string username,
        CompetitionStatus? competitionStatus = null,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .WithRoute("competitions")
            .WithRoute("standings")
            .WithQueryParameter("status", competitionStatus?.ToString())
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<IEnumerable<PlayerCompetitionStanding>>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<IEnumerable<PlayerMembership>>> GroupMemberships(
        string username,
        int? limit = null,
        int? offset = null,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .WithRoute("groups")
            .WithQueryParameter("limit", limit)
            .WithQueryParameter("offset", offset)
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<IEnumerable<PlayerMembership>>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<PlayerProgressSnapshot>> Gains(
        string username,
        Period period,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .WithRoute("gained")
            .WithQueryParameter("period", period)
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<PlayerProgressSnapshot>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<PlayerProgressSnapshot>> Gains(
        string username,
        DateTime startDate,
        DateTime endDate,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .WithRoute("gained")
            .WithQueryParameter("startDate", startDate)
            .WithQueryParameter("endDate", endDate)
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<PlayerProgressSnapshot>(cancellationToken)
    ).FlattenAsync();
}