namespace SahasraDebuggingMaster.Modules;

public static class DateBugModule
{
    public static void Run()
    {
        DateTime examDate = DateTime.Parse("31/31/2025"); // BUG 14: invalid date
        Console.WriteLine(examDate);
    }
}
