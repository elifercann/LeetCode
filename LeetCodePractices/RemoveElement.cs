namespace LeetCodePractices
{
    public class RemoveElement
    {
        public int Remove(int[] nums,int val) 
        {
            int ValCount = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i] != val)
                {
                    nums[ValCount] = nums[i];
                    ValCount++;
                }
            }
            return ValCount;
        }
    }
}
