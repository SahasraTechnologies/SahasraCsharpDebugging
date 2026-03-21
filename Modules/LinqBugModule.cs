namespace SahasraDebuggingMaster.Modules;

public static class LinqBugModule
{
    public static void Run()
    {
        var numbers = new List<int> { 2, 4, 6, 8 };
        var result = numbers.Single(x => x > 3); // BUG 12: multiple matches
        Console.WriteLine(result);
    }
}
