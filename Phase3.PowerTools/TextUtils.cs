namespace Phase3.PowerTools;

public static class TextUtils
{
    public static Dictionary<string, int> CountWords(string sentence)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        var words = sentence.Split(' ');
        foreach (string word in words)
        {
            wordCount[word] = wordCount.GetValueOrDefault(word, 0) + 1;
        }
        return wordCount;
    }
}
