using Functional.Sharp.Monads;
using JetBrains.Annotations;
using Wom.Net.Enums;
using Wom.Net.Services.Groups.Entities;

namespace Wom.Net.Contracts;

[PublicAPI]
public interface IGroupsService
{
    Task<Result<IEnumerable<GroupBulkGainsEntry>>> BulkGains(
        int id,
        Period period,
        CancellationToken cancellationToken = default
    );

    Task<Result<IEnumerable<GroupBulkGainsEntry>>> BulkGains(
        int id,
        DateTime startDate,
        DateTime endDate,
        CancellationToken cancellationToken = default
    );

    Task<Result<IEnumerable<GroupBulkHiscoresEntry>>> BulkHiscores(
        int id,
        CancellationToken cancellationToken = default
    );
}