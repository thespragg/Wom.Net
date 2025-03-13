using Functional.Sharp.Monads;
using JetBrains.Annotations;
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
}