namespace Anagram;

public class NullForReverseException : NullReferenceException
{
    public NullForReverseException(string message) : base(message)
    {
    }
}