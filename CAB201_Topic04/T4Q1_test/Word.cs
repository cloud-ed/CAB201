namespace WordAnalysis;
class Word
{
    // Insert your solution here, using the XML comments provided as a guide.
    /// <summary>
    /// Analyses the given word and returns the counts of vowels and consonants. A valid word contains only alphabetic characters.
    /// </summary>
    /// <param name="word">The word to analyze.</param>
    /// <param name="vowels">The number of vowels in the word.</param>
    /// <param name="consonants">The number of consonants in the word.</param>
    /// <returns>True if the word is valid and the analysis is successful, false otherwise.</returns>

    public static bool TryCount(string word, out int vowels, out int consonants)
    {
        char[] vowelList = new[] { 'a', 'e', 'i', 'o', 'u' };
        vowels = 0;
        consonants = 0;
        foreach (char c in word)
        {
            if (!char.IsLetter(c))
            {
                vowels = -1;
                consonants = -1;
                return false;
            }
        }
        for (int i = 0; i < word.Length; i++)
        {
            if (vowelList.Contains(char.ToLower(word[i]))) { vowels++; }
            else { consonants++; }
        }
        return true;
    }
}