namespace LeetCodePractices
{
    public class RemoveDuplicatesSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0) return 0;

            int uniqeCount = 1;

            for(int i=1; i<nums.Length; i++)
            {
                if (nums[i] != nums[uniqeCount-1])
                {
                    nums[uniqeCount] = nums[i];
                    uniqeCount++;
                }
            }
            return uniqeCount;
        }
    }
}
