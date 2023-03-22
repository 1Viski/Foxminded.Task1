namespace Anagram;

internal class Program
{
    public static void Main(string[] args)
    {
        const string line = "a1bcd efg!h";
        Console.WriteLine(Anagramer.Reverse(line));
    }
}