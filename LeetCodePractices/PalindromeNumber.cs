namespace LeetCodePractices;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if(x<0 || (x%10==0 && x != 0))
        {
            return false;
        }
        int reversed = 0;
        while(reversed < x)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return x == reversed || x == reversed/10;
    }
}
