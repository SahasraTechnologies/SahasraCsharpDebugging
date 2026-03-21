namespace SahasraDebuggingMaster.Modules;

public static class StringBugModule
{
    public static void Run()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Upper Name: " + name.ToUpper()); // BUG 9: null reference possible
        Console.WriteLine("First 5 chars: " + name.Substring(0, 5)); // BUG 10: string length issue
    }
}
