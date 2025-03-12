using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Functional.Sharp.Errors;
using Functional.Sharp.Extensions;
using Functional.Sharp.Helpers;
using Functional.Sharp.Models;
using Functional.Sharp.Monads;
using Wom.Net.Configuration;
using Wom.Net.Errors;

namespace Wom.Net.Extensions;

/// <summary>
/// Represents the message extensions for the HTTP response from an ASP.NET operation.
/// </summary>
internal static class HttpResponseMessageExtensions
{
    internal static async Task<Result<T>> ToTypedResultAsync<T>(
        this HttpResponseMessage message,
        CancellationToken cancellationToken)
        => await Try.ExecuteAsync<Result<T>>(async () =>
                {
                    if (!message.IsSuccessStatusCode)
                    {
                        var errorMessage = await message.Content.ReadAsStringAsync(cancellationToken);
                        return message.StatusCode switch
                        {
                            HttpStatusCode.BadRequest => new BadRequestError(errorMessage),
                            HttpStatusCode.Unauthorized => new UnauthorisedError(errorMessage),
                            HttpStatusCode.Forbidden => new ForbiddenError(errorMessage),
                            _ => new Error($"Unexpected HTTP error: {(int)message.StatusCode} {message.StatusCode}")
                        };
                    }

                    var content = await message.Content.ReadFromJsonAsync<T>(JsonOptions.Default, cancellationToken);

                    return content ?? throw new JsonException("Deserialized object was null.");
                },
                ex => ex switch
                {
                    JsonException => new BadRequestError($"Failed to deserialize object: {ex.Message}"),
                    _ => new Error(ex.Message)
                })
            .FlattenAsync();

    internal static async Task<Result<Unit>> ToTypedResultAsync(
        this HttpResponseMessage message,
        CancellationToken cancellationToken)
        => await Try.ExecuteAsync<Result<Unit>>(async () =>
                {
                    if (message.IsSuccessStatusCode) return new Unit();

                    var errorMessage = await message.Content.ReadAsStringAsync(cancellationToken);
                    return message.StatusCode switch
                    {
                        HttpStatusCode.BadRequest => new BadRequestError(errorMessage),
                        HttpStatusCode.Unauthorized => new UnauthorisedError(errorMessage),
                        HttpStatusCode.Forbidden => new ForbiddenError(errorMessage),
                        _ => new Error($"Unexpected HTTP error: {(int)message.StatusCode} {message.StatusCode}")
                    };
                },
                ex => new Error(ex.Message))
            .FlattenAsync();
}