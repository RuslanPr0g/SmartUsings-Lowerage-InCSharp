using System.Diagnostics;

namespace UsingLowerage.Logging;

public class TimedLogOperation : IDisposable
{
    // Inject a custom logger if you want to
    // Inject a custom log level if you want to
    private readonly string _message;
    private readonly object?[] _args;
    private readonly Stopwatch _stopwatch;

    public TimedLogOperation(string message, object?[] args)
    {
        _message = message;
        _args = args;
        _stopwatch = Stopwatch.StartNew();
    }

    public void Dispose()
    {
        _stopwatch.Stop();
        Console.WriteLine($"Finished in {_stopwatch.ElapsedMilliseconds} for some DoWork() method.\n Message: {_message}.");
    }
}
