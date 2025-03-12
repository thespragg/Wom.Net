using Functional.Sharp.Monads;
using JetBrains.Annotations;
using Wom.Net.Services.Players.Entities;

namespace Wom.Net.Contracts;

[PublicAPI]
public interface IPlayersService
{
    Task<Result<IEnumerable<Player>>> Search(
        string username,
        int? limit = default,
        int? offset = default,
        CancellationToken cancellationToken = default
    );
}