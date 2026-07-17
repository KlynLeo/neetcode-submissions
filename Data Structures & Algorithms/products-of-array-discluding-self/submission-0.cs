public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] pref = new int[nums.Length];
        int[] suf = new int[nums.Length];
        int[] res = new int[nums.Length];

        int produsPref = 1;
        pref[0] = produsPref;
        int produsSuf = 1;
        suf[nums.Length-1] = produsSuf;

        for (int i = 1; i < nums.Length; i++)
        {
            pref[i] = nums[i-1] * produsPref;
            produsPref *= nums[i-1];
        }

        for (int i = nums.Length-2; i >= 0; i--)
        {
            suf[i] = nums[i+1] * produsSuf;
            produsSuf *= nums[i+1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = pref[i] * suf[i];
        }

        return res;
    }
}
