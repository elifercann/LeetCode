namespace LeetCodePractices;

public class Solutuion
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int completed = target - nums[i];
            if (numMap.ContainsKey(completed))
            {
                return new int[] { numMap[completed], i };
            }
            numMap[nums[i]] = i;
        }
        throw new ArgumentException("No solution found");

    }
}
