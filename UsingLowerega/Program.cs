using System.Diagnostics;

/// <summary>
/// Checkout how USING keyword for the IDisposable intefrace is lowered, 
/// you can see that we have some similar pattern, 
/// so why we cannot create our own code lowering handler for things similar to this one?
/// </summary>

await DoWorkFullVersion(new Random().Next(1400, 3150));
await DoWorkSimplifiedVersion(new Random().Next(1400, 3150));

static async Task DoWorkFullVersion(int mills)
{
    // This is similar to how the USING keyword is lowered during the compilation time:

    var sw = new Stopwatch();
    try
    {
        sw.Start();
        await Task.Delay(mills);
    }
    finally
    {
        sw.Stop();
        Console.WriteLine($"Finished in {sw.ElapsedMilliseconds} for some DoWork() method.");
    }
}

static async Task DoWorkSimplifiedVersion(int mills)
{
    // Our custom high level customization for lowering during the compilation time:

    
}