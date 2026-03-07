// Contains Duplicate
// https://leetcode.com/problems/contains-duplicate/

namespace Blind75.Solutions.ArraysAndHashing;

public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        if (nums.Count() <= 0)
            return false;

        for (int i = 0; i < (nums.Count() - 1); i++)
        {
            for (int j = i + 1; j < nums.Count(); j++)
            {
                if (nums[i] == nums[j])
                    return true;
            }
        }

        return false;
    }
}
