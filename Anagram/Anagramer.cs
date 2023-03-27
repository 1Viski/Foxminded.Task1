using System.Text;

namespace Anagram;

public static class Anagramer
{
    public static string Reverse(string? line)
    {
        if (line is null)
        {
            throw new NullForReverseException("Method don't work with NULL please use string");
        }
        var result = new StringBuilder();
        var word = new StringBuilder();
        
        for (var i = 0; i < line.Length; i++)
        {
            if (line[i] != ' ')
            {
                word.Append(line[i]);
                if (i == line.Length - 1)
                {
                    result.Append(ReverseWord(word.ToString()));
                    return result.ToString();
                }
            }
            else
            {
                result.Append(ReverseWord(word.ToString()) + " ");
                word.Clear();
            }
        }

        return result.ToString();
    }

    private static string ReverseWord(string word)
    {
        var result = new StringBuilder();
        var index = word.Length - 1;
    
        for (var i = 0; i < word.Length; i++)
        {
            if (char.IsLetter(word[i]))
            {
                while (!char.IsLetter(word[index]))
                {
                    index--;
                }

                result.Append(word[index]);
                index--;
            }
            else
            {
                result.Insert(i, word[i]);
            }
        }
    
        return result.ToString();
    }
}