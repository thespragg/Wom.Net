using Functional.Sharp.Errors;

namespace Wom.Net.Errors;

public sealed record BadRequestError : Error
{
    public BadRequestError(string Message) : base(Message) { }
}