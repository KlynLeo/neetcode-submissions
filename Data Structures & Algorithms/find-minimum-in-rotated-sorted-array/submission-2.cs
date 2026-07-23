public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        int res = nums[0];

        while (l <= r) {
            int m = l + (r - l) / 2;

            if (nums[l] <= nums[m]) {
                res = Math.Min(res, nums[l]);
                l = m + 1;
            } else {
                res = Math.Min(res, nums[m]);
                r = m - 1;
            }
        }

        return res;
    }
}