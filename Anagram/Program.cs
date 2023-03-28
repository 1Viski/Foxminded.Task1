namespace Anagram;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Write some text with symbols or not: ");
        var line = Console.ReadLine();
        Console.WriteLine(Anagramer.Reverse(line));
    }
}