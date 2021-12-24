using UsingLowerage.Logging;
using UsingLowerage;

namespace UsingLowerage.Extentions;

public static class LoggerExtentions
{
    public static IDisposable TimedOperation(this CustomLogger logger, string message, params object?[] args)
    {
        return new TimedLogOperation(message, args);
    }
}
