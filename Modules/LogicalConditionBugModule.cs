namespace SahasraDebuggingMaster.Modules;

public static class LogicalConditionBugModule
{
    public static void Run()
    {
        int age = 17;
        if (age > 18 && age < 60) // BUG 20: boundary issue for 18
        {
            Console.WriteLine("Eligible");
        }
        else
        {
            Console.WriteLine("Not Eligible");
        }
    }
}
