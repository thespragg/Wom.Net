using Functional.Sharp.Extensions;
using Functional.Sharp.Helpers;
using Functional.Sharp.Monads;
using Wom.Net.Contracts;
using Wom.Net.Extensions;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Services.Players;

internal class PlayersService(HttpClient client) : IPlayersService
{
    public async Task<Result<IEnumerable<Player>>> Search(
        string username,
        int? limit = default,
        int? offset = default,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
    {
        var url =
            $"players/search?username={username}{(limit != default ? "&limit=2" : "")}{(offset != default ? "&offset=2" : "")}";
        var res = await client.GetAsync(url, cancellationToken);

        return await res.ToTypedResultAsync<IEnumerable<Player>>(cancellationToken);
    }).FlattenAsync();
}