namespace SahasraDebuggingMaster.Modules;

public static class FileBugModule
{
    public static void Run()
    {
        string path = "students-data.txt";
        string text = File.ReadAllText(path); // BUG 13: file may not exist
        Console.WriteLine(text);
    }
}
