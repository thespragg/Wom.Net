using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

namespace Wom.Net.Handlers;

internal sealed class RateLimitingHandler(int maxRequestsPerMinute, ILogger<RateLimitingHandler> logger)
    : DelegatingHandler
{
    private readonly ConcurrentQueue<DateTimeOffset> _timestamps = new();
    private readonly SemaphoreSlim _semaphore = new(1, 1);

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        await _semaphore.WaitAsync(cancellationToken);

        try
        {
            var now = DateTimeOffset.UtcNow;
            var windowStart = now.AddMinutes(-1);

            while (_timestamps.TryPeek(out var oldest) && oldest <= windowStart)
                _timestamps.TryDequeue(out _);

            if (_timestamps.Count >= maxRequestsPerMinute)
            {
                _timestamps.TryPeek(out var earliestInWindow);
                var delay = earliestInWindow.AddMinutes(1) - now;

                if (delay > TimeSpan.Zero)
                {
                    logger.LogWarning(
                        "Rate limit reached ({Count}/{Max} requests in the last minute). " +
                        "Queuing request to {Uri}, delaying for {Delay:F1}s",
                        _timestamps.Count, maxRequestsPerMinute, request.RequestUri, delay.TotalSeconds);

                    _semaphore.Release();
                    await Task.Delay(delay, cancellationToken);
                    await _semaphore.WaitAsync(cancellationToken);

                    now = DateTimeOffset.UtcNow;
                    windowStart = now.AddMinutes(-1);

                    while (_timestamps.TryPeek(out var old) && old <= windowStart)
                        _timestamps.TryDequeue(out _);
                }
            }

            _timestamps.Enqueue(DateTimeOffset.UtcNow);
        }
        finally
        {
            _semaphore.Release();
        }

        return await base.SendAsync(request, cancellationToken);
    }
}
