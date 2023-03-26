using Ardalis.GuardClauses;

namespace Api.Configurations.Envelops
{
    internal class ErrorEnvelop
    {
        public ErrorEnvelop(string message, string? stackTrace = null)
        {
            Message = Guard.Against.NullOrWhiteSpace(message, nameof(message));
            StackTrace = stackTrace;
        }

        public string Message { get; }
        public string? StackTrace { get; }
    }
}
