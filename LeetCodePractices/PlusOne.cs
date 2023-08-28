namespace LeetCodePractices;

public class PlusOne
{
    public int[] PlusOneMethod(int[] param)
    {
        int k=param.Length;

        for(int i=k-1; i>=0; i--)
        {
            if (param[i] <9)
            {
                param[i]++;
                return param;
            }
            param[i]=0;
        }
        int[] newNumber=new int[k+1];
        newNumber[0] = 1;

        return newNumber;
    }
}
