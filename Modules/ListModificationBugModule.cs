namespace SahasraDebuggingMaster.Modules;

public static class ListModificationBugModule
{
    public static void Run()
    {
        var items = new List<int> { 1, 2, 3, 4, 5 };
        foreach (var item in items) // BUG 17: collection modified during enumeration
        {
            if (item % 2 == 0)
                items.Remove(item);
        }

        Console.WriteLine(string.Join(",", items));
    }
}
