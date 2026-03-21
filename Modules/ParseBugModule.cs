namespace SahasraDebuggingMaster.Modules;

public static class ParseBugModule
{
    public static void Run()
    {
        Console.Write("Enter number: ");
        string input = Console.ReadLine() ?? "";
        int value = int.Parse(input); // BUG 18: invalid input crash
        Console.WriteLine(value * 10);
    }
}
