using JetBrains.Annotations;

namespace Wom.Net.Services.NameChanges.Entities;

/// <summary>
/// Represents the base class for review context, which can have many shapes.
/// </summary>
[PublicAPI]
public abstract record ReviewContext
{
    /// <summary>The reason for the review context.</summary>
    public string Reason { get; init; } = null!;
}