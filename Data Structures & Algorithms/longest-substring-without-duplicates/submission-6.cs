public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        int size = 0;
        int maxSize = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(!set.Contains(s[i]))
            {
                set.Add(s[i]);
                size++;
            }
            else
            {
                maxSize = Math.Max(size, maxSize);
                set.Clear();
                i = i-size;
                size = 0;
            }
        }
        maxSize = Math.Max(size, maxSize);

        return maxSize;
    }
}
