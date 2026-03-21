namespace SahasraDebuggingMaster.Modules;

public static class ArrayBugModule
{
    public static void Run()
    {
        int[] marks = { 10, 20, 30, 40, 50 };
        for (int i = 0; i <= marks.Length; i++) // BUG 11: out of range
        {
            Console.WriteLine(marks[i]);
        }
    }
}
