namespace SahasraDebuggingMaster.Modules;

public static class CalculationBugModule
{
    public static void Run()
    {
        int total = 10;
        int students = 0;
        Console.WriteLine(total / students); // BUG 15: divide by zero
    }
}
