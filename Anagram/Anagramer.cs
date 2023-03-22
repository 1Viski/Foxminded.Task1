using System.Text;

namespace Anagram;

public class Anagramer
{
    private const string LatinAlphabet = "abcdefghijklmnopqrstuvwxyz";
    
    public static string Reverse(string line)
    {
        var result = string.Empty;
        var word = string.Empty;
        
        for (var i = 0; i < line.Length; i++)
        {
            if (line[i] != ' ')
            {
                word += line[i];
                if (i == line.Length - 1)
                {
                    result += ReverseWord(word);
                    return result;
                }
            }
            else
            {
                result += ReverseWord(word) + " ";
                word = string.Empty;
            }
        }

        return result;
    }

    private static string ReverseWord(string word)
    {
        var result = new StringBuilder();

        for (var i = word.Length - 1; i >= 0; i--)
        {
            if (LatinAlphabet.Contains(word[i].ToString().ToLower()))
                result.Append(word[i]);
        }

        for (var i = 0; i < word.Length; i++)
        {
            if (!LatinAlphabet.Contains(word[i].ToString().ToLower()))
                result.Insert(i, word[i]);
        }

        return result.ToString();
    }
}