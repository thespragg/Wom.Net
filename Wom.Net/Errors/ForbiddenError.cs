using Functional.Sharp.Errors;

namespace Wom.Net.Errors;

public sealed record ForbiddenError : Error
{
    public ForbiddenError(string Message) : base(Message)
    {
    }
}