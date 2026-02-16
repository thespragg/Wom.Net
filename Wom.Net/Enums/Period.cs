using JetBrains.Annotations;

namespace Wom.Net.Enums;

/// <summary>
/// Represents a time period.
/// </summary>
[PublicAPI]
public enum Period
{
    /// <summary>Five-minute period.</summary>
    FiveMin,

    /// <summary>Daily period.</summary>
    Day,

    /// <summary>Weekly period.</summary>
    Week,

    /// <summary>Monthly period.</summary>
    Month,

    /// <summary>Yearly period.</summary>
    Year
}