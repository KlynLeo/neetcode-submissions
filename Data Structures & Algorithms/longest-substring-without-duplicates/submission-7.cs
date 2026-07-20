public class Solution {
    public int LengthOfLongestSubstring(string s) {
    var set = new HashSet<char>();
    int left = 0, maxSize = 0;

    for (int right = 0; right < s.Length; right++) {
        while (set.Contains(s[right])) {
            set.Remove(s[left]);
            left++;
        }
        set.Add(s[right]);
        maxSize = Math.Max(maxSize, right - left + 1);
    }
    return maxSize;
}
}
