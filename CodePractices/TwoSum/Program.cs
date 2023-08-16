using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Solution{
    public int[] TwoSum(int[] nums,int target)
    {
        Dictionary<int,int> numMap= new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int completed = target - nums[i];
            if (numMap.ContainsKey(completed)) 
            {
                return new int[] {numMap[completed],i};
            }
            numMap[nums[i]]=i;
        }
        throw new ArgumentException("No solution found");

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1=solution.TwoSum(nums, target1);
        Console.WriteLine("Output 1: [" + result1[0] + ", " + result1[1] + "]");
    }
}