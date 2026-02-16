using Functional.Sharp.Errors;

namespace Wom.Net.Errors;

public sealed record UnauthorisedError : Error
{
    public UnauthorisedError(string Message) : base(Message)
    {
    }
}