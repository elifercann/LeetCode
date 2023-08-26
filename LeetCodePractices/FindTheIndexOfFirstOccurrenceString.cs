namespace LeetCodePractices;

public class FindTheIndexOfFirstOccurrenceString
{
    public int StrStr(string haystack , string needle)
    {
        if (string.IsNullOrWhiteSpace(needle)) 
            return 0;
        for (int i = 0; i <=haystack.Length -needle.Length; i++)
        {
            if(haystack.Substring(i, needle.Length) == needle)
                return i;
        }
        return -1;
    }
}
