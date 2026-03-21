namespace SahasraDebuggingMaster.Modules;

public static class NullCollectionBugModule
{
    public static void Run()
    {
        List<string> names = null; // BUG 19: null collection
        Console.WriteLine(names.Count);
    }
}
