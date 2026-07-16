public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        for (int index = 0; index < nums.Length; index++)
        {
            if (!set.Contains(nums[index]))
            {
                set.Add(nums[index]);
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}