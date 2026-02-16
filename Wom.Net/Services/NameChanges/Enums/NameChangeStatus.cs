using JetBrains.Annotations;

namespace Wom.Net.Services.NameChanges.Enums;

/// <summary>
/// Represents the status of a name change request.
/// </summary>
[PublicAPI]
public enum NameChangeStatus
{
    /// <summary>The name change is pending review.</summary>
    Pending,

    /// <summary>The name change has been approved.</summary>
    Approved,

    /// <summary>The name change has been denied.</summary>
    Denied
}