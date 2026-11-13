using Functional.Sharp.Extensions;
using Functional.Sharp.Helpers;
using Functional.Sharp.Monads;
using Wom.Net.Contracts;
using Wom.Net.Enums;
using Wom.Net.Extensions;
using Wom.Net.Services.Groups.Entities;
using Wom.Net.Utils;

namespace Wom.Net.Services.Groups;

internal class GroupsService(HttpClient client) : IGroupsService
{
    public async Task<Result<IEnumerable<GroupBulkGainsEntry>>> BulkGains(
        int id,
        Period period,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("groups")
            .WithRoute(id.ToString())
            .WithRoute("bulk-gained")
            .WithQueryParameter("period", period.ToQueryValue())
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<IEnumerable<GroupBulkGainsEntry>>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<IEnumerable<GroupBulkGainsEntry>>> BulkGains(
        int id,
        DateTime startDate,
        DateTime endDate,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("groups")
            .WithRoute(id.ToString())
            .WithRoute("bulk-gained")
            .WithQueryParameter("startDate", startDate.ToQueryValue())
            .WithQueryParameter("endDate", endDate.ToQueryValue())
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<IEnumerable<GroupBulkGainsEntry>>(cancellationToken)
    ).FlattenAsync();

    public async Task<Result<IEnumerable<GroupBulkHiscoresEntry>>> BulkHiscores(
        int id,
        CancellationToken cancellationToken = default
    ) => await Try.ExecuteAsync(async () =>
        await new HttpClientBuilder(client)
            .WithRoute("groups")
            .WithRoute(id.ToString())
            .WithRoute("bulk-hiscores")
            .ExecuteGetAsync(cancellationToken: cancellationToken)
            .ToTypedResultAsync<IEnumerable<GroupBulkHiscoresEntry>>(cancellationToken)
    ).FlattenAsync();
}