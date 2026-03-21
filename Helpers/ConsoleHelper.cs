namespace SahasraDebuggingMaster.Helpers;

public static class ConsoleHelper
{
    public static void Header(string title)
    {
        Console.WriteLine();
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(title);
        Console.WriteLine(new string('=', 60));
    }

    public static string ReadText(string label)
    {
        Console.Write(label);
        return Console.ReadLine() ?? string.Empty;
    }

    public static int ReadInt(string label)
    {
        Console.Write(label);
        return int.Parse(Console.ReadLine() ?? "0");
    }

    public static decimal ReadDecimal(string label)
    {
        Console.Write(label);
        return decimal.Parse(Console.ReadLine() ?? "0");
    }
}
