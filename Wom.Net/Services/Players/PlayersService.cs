using Functional.Sharp.Extensions;
using Functional.Sharp.Helpers;
using Functional.Sharp.Monads;
using Wom.Net.Contracts;
using Wom.Net.Extensions;
using Wom.Net.Services.Players.Responses;
using Wom.Net.Utils;

namespace Wom.Net.Services.Players;

internal class PlayersService(HttpClient client) : IPlayersService
{
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
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("players")
            .WithRoute(username)
            .ExecutePostAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<GetPlayerDetailsResponse>(cancellationToken)
    ).FlattenAsync();

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
}