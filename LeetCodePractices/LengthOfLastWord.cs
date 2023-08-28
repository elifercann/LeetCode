namespace LeetCodePractices;

public class LengthOfLastWord
{
    public int LengthLastWord(string word)
    {
        word = word.Trim();

        int lastSpaceIndex=word.LastIndexOf(' ');

        if(lastSpaceIndex == -1)
        {
            return word.Length;
        }
        else
        {
            return word.Length - lastSpaceIndex - 1;
        }
           
    }
}
