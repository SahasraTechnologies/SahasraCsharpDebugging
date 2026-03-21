namespace SahasraDebuggingMaster.Modules;

public static class AsyncBugModule
{
    public static async Task Run()
    {
        var task = GetMessageAsync();
        Console.WriteLine(task.Result); // BUG 16: bad practice / potential blocking
    }

    private static async Task<string> GetMessageAsync()
    {
        await Task.Delay(500);
        return "Async module completed.";
    }
}
