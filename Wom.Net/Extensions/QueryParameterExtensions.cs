using System.Globalization;
using Wom.Net.Enums;

namespace Wom.Net.Extensions;

/// <summary>
/// Represents the extensions for formatting query parameter values for the WiseOldMan API.
/// </summary>
internal static class QueryParameterExtensions
{
    internal static string ToQueryValue(this Period period) => period switch
    {
        Period.FiveMin => "five_min",
        Period.Day => "day",
        Period.Week => "week",
        Period.Month => "month",
        Period.Year => "year",
        _ => throw new ArgumentOutOfRangeException(nameof(period), period, null)
    };

    internal static string ToQueryValue(this DateTime date) =>
        date.ToString("O", CultureInfo.InvariantCulture);
}