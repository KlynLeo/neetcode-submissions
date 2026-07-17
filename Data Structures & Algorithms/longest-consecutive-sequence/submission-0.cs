public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int maxLength = 0;

        foreach (int num in set) {
            if (!set.Contains(num - 1)) {
                int lungime = 1;
                int curent = num;

                while (set.Contains(curent + 1)) {
                    curent++;
                    lungime++;
                }

                maxLength = Math.Max(maxLength, lungime);
            }
        }

        return maxLength;
    }
}