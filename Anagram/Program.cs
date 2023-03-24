namespace Anagram;

internal static class Program
{
    public static void Main(string[] args)
    {
        const string? line = "a12345";
        Console.WriteLine(Anagramer.Reverse(line));
    }
}